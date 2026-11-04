// Online C# compiler (editor) for free
// Write and run C# online using this editor.
using System;
using System.Collections;

public class HelloWorld {
    public static void Main(string[] args) {
        SortedList a = new SortedList();
        a.Add(1,"Hi");
        
        a.Add(3,"hello");
        a.Add(2,"Hi");
        foreach(DictionaryEntry obj in a){
            Console.WriteLine(obj.Key + " "+obj.Value);
        }
    
        
    }
}