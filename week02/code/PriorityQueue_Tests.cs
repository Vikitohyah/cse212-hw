using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.


[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add two items with different priorities
    // Expected Result: The items should be added in the order of their priorities, with the highest priority item at the front.
    // Defect(s) Found: I dont expect any defects to be found in this test.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
    
        priorityQueue.Enqueue("Adam", 4);
        priorityQueue.Enqueue("Boye", 7);
        priorityQueue.Enqueue("Daniel", 3);

        Assert.AreEqual("[Adam (Pri:4), Boye (Pri:7), Daniel (Pri:3)]",
            priorityQueue.ToString()
        );
    }

    [TestMethod]
    // Scenario: Add three items with different priorities and dequeue them.
    // Expected Result: It is expected that the items will be dequeued in order of their priority, with the highest priority item being dequeued first.
    // Defect(s) Found: The Dequeue method was not correctly identifying the item with the highest priority, which lead to an incorrect order of the items getting dequeued. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Yennifer", 2);
        priorityQueue.Enqueue("Hermione", 3);
        priorityQueue.Enqueue("Hagrid", 5);

        Assert.AreEqual("Hagrid", priorityQueue.Dequeue());

        Assert.AreEqual(
            "[Yennifer (Pri:2), Hermione (Pri:3)]",
            priorityQueue.ToString()
        );

        Assert.AreEqual("Hermione", priorityQueue.Dequeue());
        Assert.AreEqual("Yennifer", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The items with the same highest priority should be dequeued in the order they were added to the queue (FIFO order).
    // Defect(s) Found: I found that using the >= instead of > operator in the Dequeue method made the last item with the samme highest priority to be dequeued first, which is not what we are expecting
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Lonlo", 5);
        priorityQueue.Enqueue("Evi", 2);
        priorityQueue.Enqueue("Mawu", 5);

        Assert.AreEqual("Lonlo", priorityQueue.Dequeue());
        Assert.AreEqual("Mawu", priorityQueue.Dequeue());
        Assert.AreEqual("Evi", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty".
    // Defect(s) Found: The Dequeue method was not properly handling the case when the queue is empty, leading to an unexpected behavior.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}