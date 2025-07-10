using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    /// <summary>
    /// Test the behavior of an empty priority queue.
    /// </summary>
    [TestMethod]
    // Scenario: Creating a new PriorityQueue and attempting to dequeue.
    // Expected Result: An exception is thrown (e.g., InvalidOperationException).
    // Defect(s) Found: None yet – to be verified.
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();

        // This assumes PriorityQueue throws an exception when dequeuing from an empty queue.
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    /// <summary>
    /// Test enqueuing and dequeuing a single item.
    /// </summary>
    [TestMethod]
    // Scenario: Add a single item with a priority and then remove it.
    // Expected Result: The item dequeued should match the enqueued item.
    // Defect(s) Found: None yet – to be verified.
    public void TestPriorityQueue_SingleEnqueueDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 10);

        var item = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", item);
    }

    /// <summary>
    /// Test the order of multiple items based on priority.
    /// </summary>
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities.
    // Expected Result: Items are dequeued in order of highest priority first.
    // Defect(s) Found: None yet – to be verified.
    public void TestPriorityQueue_MultiplePriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 100);
        priorityQueue.Enqueue("Medium", 50);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    // Add more test cases below to check edge cases, duplicate priorities, etc.
}
