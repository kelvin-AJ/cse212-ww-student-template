using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue with the following items and priorities: Tayo (2), Femi (1), Tobi (2), Jude (3) and run until the queue is empty
    // Expected Result: Jude, Tayo, Tobi, Femi
    // Defect(s) Found: There was an issue with the Dequeue method where it was not correctly identifying the item with the highest priority. I fixed the loop by starting the index at 0 and checking for greater than instead of greater than or "equal to" to ensure that the first item with the highest priority is returned.

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Femi", 1);
        priorityQueue.Enqueue("Tayo", 2);
        priorityQueue.Enqueue("Tobi", 2);
        priorityQueue.Enqueue("Jude", 3);

        Assert.AreEqual("Jude", priorityQueue.Dequeue());
        Assert.AreEqual("Tayo", priorityQueue.Dequeue());
        Assert.AreEqual("Tobi", priorityQueue.Dequeue());
        Assert.AreEqual("Femi", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: We will create an empty queue and attempt to dequeue. 
    // Expected Result:  This exception should be an InvalidOperationException with a message of "The queue is empty."
    // Defect(s) Found: No Defect Found
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty.");

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}