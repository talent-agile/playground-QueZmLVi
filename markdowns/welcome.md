# Linq Exercises

Complete the following Linq Exercises

## Total Order Price

The goal of this exercise is to calculate the total profit from all orders.

You can use the ``Order.Price`` property to get the total price for a single order.

@[Calculate the sum of all order prices]({"stubs": ["Exercises/TotalOrderSum.cs"],"command": "Linq.LinqTests.CheckTotalOrderSum"})

## Number of orders in April 2016

Objective: Find the number of orders made in April 2016.

@[Numbers of orders in April 2016]({"stubs": ["Exercises/NumberOfOrdersInApril2016.cs"], "command": "Linq.LinqTests.CheckNumberOfOrdersInApril2016"})

## Month with highest income

Objective: Find the month with the highest income.

### Tips

* Try to group orders by their order date with the ``Order.Date`` property

@[Month with highest income]({"stubs": ["Exercises/MonthWithHighestIncome.cs"], "command": "Linq.LinqTests.CheckMonthWithHighestIncome"})

## Three monthes with lowest income

Objective: Find the three monthes with the lowest income, ordered from lowest to highest

@[Monthes with lowest income]({"stubs": ["Exercises/MonthesWithLowestIncome.cs"], "command": "Linq.LinqTests.CheckMonthesWithLowestIncome"})