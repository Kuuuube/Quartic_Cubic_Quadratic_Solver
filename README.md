# Quartic Cubic Quadratic Solver
Code snippets for solving Quartic, Cubic, and Quadratic equations.

One_Seven_Two_Eight_Quartic.cs can return all cubic and quartic roots.

FQS_Quartic.cs can return all quadratic roots, the first cubic root and all quartic roots.

Approximate Benchmark Results from FQS and One_Seven_Two_Eight:

| Algorithm                       | Repetition Count | Total Time | Time Per Repetition | 
| :------------------------------ | :--------------- | :--------- | ------------------: |
| FQS Quartic                     | 100,000,000      | 33200 ms   | 0.00033200442 ms    |
| One_Seven_Two_Eight Quartic     | 100,000,000      | 182742 ms  | 0.00182742306 ms    |
| FQS Cubic                       | 100,000,000      | 17626 ms   | 0.00017626653 ms    |
| One_Seven_Two_Eight Cubic       | 100,000,000      | 99729 ms   | 0.00099729341 ms    |
| FQS Quadratic                   | 100,000,000      | 5041 ms    | 0.00005041385 ms    |