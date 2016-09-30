//12.Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

  class RemoveAllListedWords
  {
      //All files are in directory bin/Debug
      static List<string> GetWords()
      {
          StreamReader reader = new StreamReader("words.txt");
          List<string> list = new List<string>();

          using (reader)
          {
              string word = reader.ReadLine();
              while (word != null)
              {
                  list.Add(word);
                  word = reader.ReadLine();
              }
          }
          return list;
      }

      static void Main()
      {
          try
          {
              List<string> list = GetWords();
              StreamReader reader = new StreamReader("text.txt");
              StreamWriter writer = new StreamWriter("result.txt");

              using (reader)
              using (writer)
              {
                  string line = reader.ReadLine();
                  while (line != null)
                  {
                      for (int i = 0; i < list.Count; i++)
                      {
                          string word = list[i];
                          line = line.Replace(word, " ");
                      }
                      writer.WriteLine(line);
                      line = reader.ReadLine();
                  }
              }
              Console.WriteLine("Done!");
          }
          catch (FileNotFoundException e)
          {
              Console.WriteLine(e.Message);
          }

          catch (DirectoryNotFoundException e)
          {
              Console.WriteLine(e.Message);
          }

          catch (IOException e)
          {
              Console.WriteLine(e.Message);
          }

          catch (SecurityException e)
          {
              Console.WriteLine(e.Message);
          }

          catch (UnauthorizedAccessException e)
          {
              Console.WriteLine(e.Message);
          }
      }
  }

