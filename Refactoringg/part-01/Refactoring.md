# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?  the problem is the switch statement bec adding new carrier requires changing the code inside
- What did you change?  i create interface for the carrier and create a class for each carrier that implements the interface. then i create a factory class to return the correct carrier based on the input.

---

## OrderProcessor

- What was the problem?   thi is tightly coupled  high level business logic to concrete implementations violating (DIP)
- What did you change? making abstraction interface  and inject them via constractor injection into order processor

---

## Notifications

- What was the problem? every time new feature is added we need to create combination of every subclass
- What did you change? create interface and implement bas channels and create decorator

---

## Proof

- New carrier file(s):  UperShippingCostStrategy
- New notification channel file(s): UperShippingCostStrategy
- Existing classes left unchanged? (yes/no): yes
