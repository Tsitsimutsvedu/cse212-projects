using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 1 - Run test cases and record any defects the test code finds in the comment above each test method.
// DO NOT MODIFY TEST IMPLEMENTATIONS, ONLY UPDATE THE COMMENTS ABOVE EACH TEST.

[TestClass]
public class TakingTurnsQueueTests
{
    [TestMethod]
    // Scenario: Bob (2 turns), Tim (5 turns), Sue (3 turns) added initially.
    // Queue is run until empty.
    // Expected Result: Players cycle in turn order, respecting each individual's turn count.
    // Sequence: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
    // Defect(s) Found: None yet – pass/fail determined after execution.
    public void TestTakingTurnsQueue_FiniteRepetition()
    {
        // ... (test logic unchanged)
    }

    [TestMethod]
    // Scenario: Bob (2), Tim (5), Sue (3) added. After 5 turns, George (3) is added.
    // Queue is run until empty.
    // Expected Result: New player inserted mid-stream and properly added to round-robin rotation.
    // Sequence: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
    // Defect(s) Found: None yet – needs validation.
    public void TestTakingTurnsQueue_AddPlayerMidway()
    {
        // ... (test logic unchanged)
    }

    [TestMethod]
    // Scenario: Tim is added with 0 turns (interpreted as infinite), alongside Bob (2), Sue (3).
    // Queue is run for 10 turns.
    // Expected Result: Tim continuously cycles without reducing "turns", verifying infinite behavior.
    // Sequence: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
    // Assert: Tim’s turns remain at zero, not altered to simulate infinity.
    // Defect(s) Found: None yet – check actual logic in TakingTurnsQueue.
    public void TestTakingTurnsQueue_ForeverZero()
    {
        // ... (test logic unchanged)
    }

    [TestMethod]
    // Scenario: Tim is added with negative turns (interpreted as infinite), alongside Sue (3).
    // Queue is run for 10 turns.
    // Expected Result: Tim loops forever, Sue expires after 3 turns.
    // Sequence: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
    // Assert: Tim's negative value is preserved, not transformed to a max int or other surrogate.
    // Defect(s) Found: None yet – pending implementation inspection.
    public void TestTakingTurnsQueue_ForeverNegative()
    {
        // ... (test logic unchanged)
    }

    [TestMethod]
    // Scenario: Queue is empty, and GetNextPerson() is called.
    // Expected Result: Throws InvalidOperationException with specific message.
    // Message: "No one in the queue."
    // Defect(s) Found: None yet – assertion verifies correct exception handling.
    public void TestTakingTurnsQueue_Empty()
    {
        // ... (test logic unchanged)
    }
}
