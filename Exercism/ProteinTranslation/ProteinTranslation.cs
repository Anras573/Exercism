namespace Exercism.ProteinTranslation;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        if (string.IsNullOrWhiteSpace(strand))
            return Array.Empty<string>();
        
        var codons = strand.Chunk(3);
        
        return codons
            .Select(chunk => FromCodon(new string(chunk)))
            .TakeWhile(protein => protein != "STOP")
            .ToArray();
    }

    private static string FromCodon(string codon)
        => codon switch
        {
            "AUG" => "Methionine",
            "UUU" or "UUC" => "Phenylalanine",
            "UUA" or "UUG" => "Leucine",
            "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
            "UAU" or "UAC" => "Tyrosine",
            "UGU" or "UGC" => "Cysteine",
            "UGG" => "Tryptophan",
            "UAA" or "UAG" or "UGA" => "STOP",
            _ => throw new ArgumentException("Invalid codon")
        };
}