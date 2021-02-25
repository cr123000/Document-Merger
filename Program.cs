using System;
using System.IO; 
namespace document_merger
{
    public class merger
        {
            public string content1,content2,document1,document2,mergedContent,mergedName,ErrorCode;
            public merger()
            {
                 document1=getFileName(1);
                 document2=getFileName(2);
                 content1=scanfile(document1);
                 content2=scanfile(document2);
                 mergedName=rename(document1,document2);
                 mergedContent+=content1+content2;
                 ErrorCode=merge(mergedName,mergedContent);
            }
            public string merge(string  mergedName,string  mergedContent)
            {
                try{
                StreamWriter sr= new StreamWriter(mergedName);
                sr.WriteLine(mergedContent);
                sr.Close();
                return($"{mergedName} was successfully saved. The document contains {mergedContent.Length} characters");
                }
                catch(Exception e)
                {
                    return(e.Message);
                }
            }
            public string scanfile(string WD)
            {
                int len=WD.Length;
                if(!(WD[len-1]=='t' && WD[len-2]=='x' &&WD[len-3]=='t'&&WD[len-4]=='.'))
                {
                            WD+=".txt";
                        }
                string content;
                StreamReader sr = new StreamReader(WD);
                content=sr.ReadToEnd();
                sr.Close();
                return content;
            }
            public string getFileName(int tryNumber)
            {
                string name;
                while(true)
                {
                    Console.WriteLine($"Please enter name of ducement{tryNumber}:");
                    name=Console.ReadLine();
                    if(name==""||name==".txt"){
                        Console.WriteLine("File name cannot be blank.");
                        continue;
                    }
                    Boolean bl=isInDirectory(name);
                    if(bl)
                    {
                        int len=name.Length;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                return name.Replace(".txt","");
            }
            public string rename(string name1,string name2)
            {
                while(true){
                    string name;
                    Console.WriteLine($"What would you like the string to be called?\nfor default,({name1+name2+".txt"}), input -1:");
                    name=Console.ReadLine();
                    if(name==""||name==".txt"){
                            Console.WriteLine("File name cannot be blank.");
                            continue;
                        }
                    if(name!="-1")
                    {
                        int len=name.Length;
                        if(!(name[len-1]=='t' && name[len-2]=='x' &&name[len-3]=='t'&&name[len-4]=='.')){
                            name+=".txt";
                        }
                        return name;
                    }
                    else
                    {
                        return(name1+name2+".txt");
                    }
                }
            }
            public bool isInDirectory(string name)
            {
                try
                {
                    int len=name.Length;
                    if(!(name[len-1]=='t' && name[len-2]=='x' &&name[len-3]=='t'&&name[len-4]=='.'))
                {
                            name+=".txt";
                        }
                    StreamReader sr = new StreamReader(name);
                    if(sr==null){
                        Console.WriteLine("File is empty or missing.");
                        return false;
                    }
                    sr.Close();
                    return true;
                }
                catch(FileNotFoundException)
                {
                    Console.WriteLine("Cannot find file.");
                    return false;
                }    
            }
        }
    class Program
    {       
        static void Main(string[] args)
        { 
            Console.WriteLine("Document Merger\n");
            while(true){
                merger merge=new merger();
                Console.WriteLine(merge.ErrorCode+" Input y to do it again or enter any other character to exit.");
                string input=Console.ReadLine();
                if(input=="y"){
                    continue;
                }
                else{
                    break;
                }
                
            }
        }

    }
}
