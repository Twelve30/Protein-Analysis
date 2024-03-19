using System;
using System.IO;
using System.Text;
class Primarycheck
{
    public void Checker(string input, string name)
    {
        string strnew = input.ToUpper();
        Console.WriteLine("Enter the single digit code of the particular Amino Acid");
        string aminoacid = Console.ReadLine(), aa = aminoacid.Trim();
        Console.WriteLine("");
        try
        {
         for (int j = 0; j < aa.Length; j++)
            {
                string trimmed = "";
                for (int i = 0; i < strnew.Length; i++)
                {
                    if (strnew[i] == char.ToUpper(aa[j]))
                    {
                        trimmed += strnew[i];
                    }
                    else
                    {
                        continue;
                    }
                }
                    double d = ((double)trimmed.Length / (double)strnew.Length) * 100;
                    Console.WriteLine("The number of " + char.ToUpper(aa[j]) + " residues in " + name + " is " + trimmed.Length);
                    Console.WriteLine("The percentage of " + char.ToUpper(aa[j]) + " in the protein is " + d + "%");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
            }
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.WriteLine("");
        }
        catch { Console.WriteLine("Some error occured"); }

    }
}
class Mainprog
{
    public static void Main()
    {
        Primarycheck pc = new Primarycheck();
        Stream inputstream = Console.OpenStandardInput();
        const int BufferSize = 4096;
        Console.SetIn(new StreamReader(Console.OpenStandardInput(), Encoding.UTF8, false, BufferSize));
        string breaker = "";
        Console.WriteLine(@"Single digit amino acid code:
 
        Glycine	        GLY	    G
        Alanine	        ALA	    A
        Valine	        VAL	    V
        Leucine	        LEU	    L
        IsoLeucine	ILE    	    I
        Threonine	THR    	    T
        Serine	        SER	    S
        Methionine	MET    	    M
        Cysteine	CYS    	    C
        Proline	        PRO	    P
        Phenylalanine	PHE	    F
        Tyrosine	TYR    	    Y
        Tryptophan  	TRP	    W
        Histidine	HIS    	    H
        Lysine	        LYS	    K
        Argenine	ARG    	    R
        Aspartate	ASP    	    D
        Glutamate   	GLU	    E
        Asparagine	ASN    	    N
        Glutamine	GLN    	    Q");
        for (; ; )
        {
            Console.WriteLine("Enter the protein name");
            string cmd = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Enter the sequence");
            string name = Console.ReadLine();
            Console.WriteLine("");
            if (cmd == breaker.Trim()) { break; }
            else { pc.Checker(name, cmd); }
        }
        
    }
}