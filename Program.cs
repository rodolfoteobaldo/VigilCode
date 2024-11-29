using System.Text;

const string text = "In 1991, while studying computer science at University of Helsinki, Linus Torvalds began a project that later became the Linux kernel. He wrote the program specifically for the hardware he was using and independent of an operating system because he wanted to use the functions of his new PC with an 80386 processor. Development was done on MINIX using the GNU C Compiler.";

var result = new StringBuilder();
var accumulateWords = string.Empty;

foreach (var word in text.Split(' '))
{
    if (accumulateWords.Length + word.Length <= 40)
    {
        accumulateWords += word + ' ';
        continue;
    }

    if (accumulateWords.Trim().Length == 40)
    {
        result.AppendLine(accumulateWords);
        accumulateWords = word + ' ';
        continue;
    }
    
    result.AppendLine(accumulateWords);
    accumulateWords = word + ' ';
}

if (accumulateWords.Trim().Length > 0)
    result.AppendLine(accumulateWords);

Console.WriteLine(result.ToString());
