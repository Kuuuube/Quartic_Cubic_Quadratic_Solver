# Quartic Cubic Quadratic Solver

Code snippets for solving Quartic, Cubic, and Quadratic equations.

## Info

One_Seven_Two_Eight is more accurate but slower than FQS.

`One_Seven_Two_Eight_Quartic.cs` can return all cubic roots and all quartic roots.

`FQS_Quartic.cs` can return all quadratic roots, the first cubic root, and all quartic roots.

## Approximate Benchmark Results

| Algorithm                       | Repetition Count | Total Time | Time Per Repetition | 
| :------------------------------ | :--------------- | :--------- | ------------------: |
| FQS Quartic                     | 100,000,000      | 33200 ms   | 0.33200442 μs       |
| One_Seven_Two_Eight Quartic     | 100,000,000      | 182742 ms  | 1.82742306 μs       |
| FQS Cubic                       | 100,000,000      | 17626 ms   | 0.17626653 μs       |
| One_Seven_Two_Eight Cubic       | 100,000,000      | 99729 ms   | 0.99729341 μs       |
| FQS Quadratic                   | 100,000,000      | 5041 ms    | 0.05041385 μs       |