# Quartic Cubic Quadratic Solver
Code snippets for solving Quartic, Cubic, and Quadratic equations.

One_Seven_Two_Eight_Quartic.cs can return all cubic and quartic roots.

FQS_Quartic.cs can return all quadratic roots, the first cubic root and all quartic roots.

Approximate Benchmark Results:

| Algorithm                       | Repetition Count | Total Time | Time Per Repetition | 
| :------------------------------ | :--------------- | :--------- | ------------------: |
| FQS Quartic                     | 100,000,000      | 33611 ms   | 0.000336 ms         |
| FQS Cubic                       | 100,000,000      | 17607 ms   | 0.000176 ms         |
| FQS Quadratic                   | 100,000,000      | 5125 ms    | 0.000051 ms         |
| One_Seven_Two_Eight Quartic     | 100,000,000      | 181778 ms  | 0.001817 ms         |
| One_Seven_Two_Eight Cubic       | 100,000,000      | 99342 ms   | 0.000993 ms         |
