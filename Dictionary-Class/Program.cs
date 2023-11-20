// CSC 204 - Algorithms
// Project 1, Caleb Hyatt

using Project1;

var myDict = new Webster();

/* Scenario 0b */
myDict.Add("box");
myDict.Add("book");
myDict.Add("build");
myDict.Add("car");
myDict.Add("can");
myDict.Add("CSC204");

/* Scenario 1 */
var s1 = myDict.GetWordsForPrefix("bo");
Console.WriteLine($"Scenario 1 // GetWordsForPrefix(\"bo\")\n\n{string.Join("\n", s1)}");

/* Scenario 2 */
var s2 = myDict.GetWordsForPrefix("ca");
Console.WriteLine($"\nScenario 2 // GetWordsForPrefix(\"ca\")\n\n{string.Join("\n", s2)}");

/* Scenario 3 & 4 */
myDict.Delete("box");
// myDict.Delete("boom"); // this will throw an error in the project; comment out to continue
Console.WriteLine("\nScenario 3 & 4 // Delete(\"box\") and Delete(\"boom\")");

/* Scenario 5 */
var s5 = myDict.GetAllWords();
Console.WriteLine($"\nScenario 5 // GetAllWords()\n\n{string.Join("\n", s5)}");

/* Scenario 6 */
// myDict.Add("book"); // this will throw an error in the project; comment out to continue
Console.WriteLine("\nScenario 6 // Add(\"book\")");

/* Scenario 7 */
var s7 = myDict.Size();
Console.WriteLine($"\nScenario 7 // Size\n{s7}");

/* Scenario 8 - in separate file */

/* Scenario 9 */
myDict.SetState(Webster.States.ReadOnly);
Console.WriteLine("\nScenario 9 // SetState(Webster.States.ReadOnly)");

/* Secnario 10 */
myDict.Add("this is a test");
Console.WriteLine("\nScenario 10 // Add(\"this is a test\")");
Console.WriteLine("This does not throw an error, rather it will return nothing.");

/* Scenario 11 */
myDict.SetState(Webster.States.Disabled);
Console.WriteLine("\nScenario 11 // SetState(Webster.States.Disabled)");

/* Scenario 12 */
var s12 = myDict.GetWordsForPrefix("b");
Console.WriteLine("\nScenario 12 // GetWordsForPrefix(\"b\")");
Console.WriteLine(s12.Count.ToString());

/* Scenario 13 */
myDict.SetState(Webster.States.ReadWrite);
Console.WriteLine("\nScenario 13 // SetState(Webster.States.ReadWrite)");

/* Scenario 14 */
myDict.DeleteAllWords(true);
Console.WriteLine("\nScenario 14 // DeleteAllWords(true)");