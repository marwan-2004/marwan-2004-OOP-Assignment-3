&#x20;#1:  IReadOnlyDictionary<TKey, TValue> : provides read-only access to a dictionary, allowing you to safely expose key/value pairs without permitting modifications



Difference : A Dictionary<TKey, TValue> is mutable and allows adding, removing, and updating items, while an IReadOnlyDictionary<TKey, TValue> provides a read-only view of key/value pairs without modification capabilities



A public method returns `IReadOnlyDictionary` to encapsulate internal class state



\#2:  sortedDictionary is different from Dictionary in that uses binary search tree for retrieval , which allows for O(log n) lookup speed this makes it faster than Dictionary for unsorted data  , but it uses more memory 
 i choose sortedDictionary  if the order of element is important and the lookup speed is priority





task #2.2:

1-Dictionary<string, Student> because it  Provides O(1) average lookup time by student national ID key

2-HashSet<string> it prevents duplicate 

3-List<int> preserve insertion order for student and allow duplicate values

4-IReadOnlyDictionary<string, decimal>  prevent modifying anything allow only read

5-SortedDictionary<DateTime, Session> maintains session keys sorted by start time whenever new sessions are inserted

6-IEnumerable<Session>Supports lazy execution , computing elements on-demand and can stop early

