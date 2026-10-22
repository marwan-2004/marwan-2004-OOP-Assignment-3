using RefactoringLab.Part03.BlockedUsers;
using RefactoringLab.Part03.Students;

Console.WriteLine("=== Blocked Users & Students ===");


var blockedIds = BlockedUserChecker.BuildBlockedIds(50_000);
var requestIds = BlockedUserChecker.BuildRequestIds(100_000, 100_000);

var elapsedMs = BlockedUserChecker.MeasureMs(blockedIds, requestIds, out var found);
Console.WriteLine($"Found {found} blocked requests in {elapsedMs} ms");


Console.WriteLine("\nFirst 3 Students:");
var count = 0;
foreach (var student in StudentCatalog.GetAllStudents())
{
    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
    count++;
    if (count == 3) break; 
}