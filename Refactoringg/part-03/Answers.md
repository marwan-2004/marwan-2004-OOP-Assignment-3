# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(N x M)
- Time (ms) before:20ms
- What did you change? convert to hash set
- Time complexity after:O(N + M) — O(N)
- Time (ms) after:5ms

---

## Students

- What was the problem? used eager evaluation, allocating memory and instantiating all 1,000,000 Student objects upfront in a List<Student>. Even though we only read 3 students
- What did you change? Changed GetAllStudents() to return IEnumerable<Student> using yield return for lazy evaluation
