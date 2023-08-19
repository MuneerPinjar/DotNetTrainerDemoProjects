using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Creating a sample tree structure
        var rootQuestion = new QuestionBase
        {
            Name = "What is your favorite color?",
            AnswerJson = "{\"answer\": \"Blue\"}",
            Children = new List<QuestionBase>
            {
                new QuestionBase
                {
                    Name = "What is your favorite animal?",
                    AnswerJson = "{\"answer\": \"Dog\"}",
                    Children = new List<QuestionBase>
                    {
                        new QuestionBase
                        {
                            Name = "What is your dog's name?",
                            AnswerJson = "{\"answer\": \"Max\"}",
                            Children = new List<QuestionBase>
                            {
                              new QuestionBase
                              {
                                  Name = "What is your car name?",
                                  AnswerJson = "{\"answer\": \"Max fury\"}",
                                  Children = null // No more child nodes for this question
                              },
                               new QuestionBase
                              {
                                  Name = "What is your car name?",
                                  AnswerJson = "{\"answer\": \"Max fury\"}",
                                  Children = null // No more child nodes for this question
                              },
                                new QuestionBase
                              {
                                  Name = "What is your car name?",
                                  AnswerJson = "{\"answer\": \"Max fury\"}",
                                  Children = null // No more child nodes for this question
                              },
                               new QuestionBase
                              {
                                  Name = "What is your car name?",
                                  AnswerJson = "{\"answer\": \"Max fury\"}",
                                  Children = null // No more child nodes for this question
                              }
                            }
                        }
                    }
                },
                new QuestionBase
                {
                    Name = "What is your favorite food?",
                    AnswerJson = "{\"answer\": \"Pizza\"}",
                    Children = null // No more child nodes for this question
                }
            }
        };


        // Boxing --> Convert value type to reference type

        int val = 10;

        // Boxing 
        object obj = val;

        Console.WriteLine("Obejct : "+obj);

        // unboxing --> convert reference type to value tpye

        int nnum = 1000;

        object obj2 = nnum; //boxing -- Implicit conversion

        int i = (int)obj2;//unboxing -- Explicit conversion



        // Displaying the tree structure
        PrintQuestion(rootQuestion, 0);
    }

    public static void PrintQuestion(QuestionBase question, int level)
    {
        string indent = new string(' ', level * 2);
        Console.WriteLine($"{indent}{question.Name}");
        Console.WriteLine($"{indent}Answer: {question.AnswerJson}");

        if (question.Children != null)
        {
            foreach (var child in question.Children)
            {
                PrintQuestion(child, level + 1);
            }
        }
    }
}

public class QuestionBase
{
    public string Name { get; set; }
    public string AnswerJson { get; set; }
    public List<QuestionBase> Children { get; set; }
}
