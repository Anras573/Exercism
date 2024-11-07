using Sut = Exercism.ProteinTranslation.ProteinTranslation;

namespace Exercism.Test.ProteinTranslation;

[TestClass]
public class ProteinTranslationTests
{
    [TestMethod]
    public void Empty_strand_yields_no_proteins()
    {
        const string strand = "";
        var expected = Array.Empty<string>();
        Assert.AreEqual(expected, Sut.Proteins(strand));
    }
    
    [TestMethod]
    [DynamicData(nameof(AllProteins), DynamicDataSourceType.Method)]
    public void Codons_yields_proteins(string codon, string[] protein)
    {
        var actual = Sut.Proteins(codon);
        CollectionAssert.AreEqual(protein, actual);
    }
    
    [TestMethod]
    public void Stop_codon_yields_no_proteins()
    {
        const string strand = "UAA";
        var expected = Array.Empty<string>();
        Assert.AreEqual(expected, Sut.Proteins(strand));
    }
    
    [TestMethod]
    public void Stop_codon_in_middle_of_strand_yields_proteins_up_to_stop_codon()
    {
        const string strand = "AUGUAGUGU";
        var expected = new[] { "Methionine" };
        CollectionAssert.AreEqual(expected, Sut.Proteins(strand));
    }
    
    [TestMethod]
    public void Invalid_codon_yields_exception()
    {
        const string strand = "AUGUGUFFF";
        Assert.ThrowsException<ArgumentException>(() => Sut.Proteins(strand));
    }
    
    public static IEnumerable<object[]> AllProteins()
    {
        yield return ["AUG", new[] { "Methionine" }];
        yield return ["UUU", new[] { "Phenylalanine" }];
        yield return ["UUC", new[] { "Phenylalanine" }];
        yield return ["UUA", new[] { "Leucine" }];
        yield return ["UUG", new[] { "Leucine" }];
        yield return ["UCU", new[] { "Serine" }];
        yield return ["UCC", new[] { "Serine" }];
        yield return ["UCA", new[] { "Serine" }];
        yield return ["UCG", new[] { "Serine" }];
        yield return ["UAU", new[] { "Tyrosine" }];
        yield return ["UAC", new[] { "Tyrosine" }];
        yield return ["UGU", new[] { "Cysteine" }];
        yield return ["UGC", new[] { "Cysteine" }];
        yield return ["UGG", new[] { "Tryptophan" }];
    }
}