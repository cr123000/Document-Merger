using System;
using System.IO; 

namespace document_merger
{
    class Program
    {
        public class document_merger{
            public string content1;
            public string content2;
            public string document1;
            public string document2;
            public document_merger(){
                 document1=getFileName(1);
                 document2=getFileName(2);
                 content1=scanfile(document1);
                 content2=scanfile(document2);
                
            }
            public void merge(){
                string content3;
                content3=content1+content2;
                
            }
            public string scanfile(string WD){

            }
            public string getFileName(int tryNumber){
                string name;
                do{
                    Console.WriteLine($"Please enter name of ducement{tryNumber}:");
                    name=Console.ReadLine();
                    int len=name.Length;
                    if(name[len-1]=='t' && name[len-2]=='x' &&name[len-3]=='t'&&name[len-4]=='.'){
                        name=@"\"+name;
                    }
                }while(isInDirectory(name));
            }
            public string rename(){

            }
            public Boolean isInDirectory(string name){
                
            }
            public 

        }
        static void Main(string[] args)
        { 
            string content="",document1="",document2 = "",WD=@"\";
            Console.WriteLine("Document Merger\n");
            do{
                while(true){
                    try{ Console.WriteLine("Please input first document to merge.");
                    
                    }
                    catch{

                    }
                }
            }while(true);
            document_merger merge=new document_merger();

        }
    }
}
