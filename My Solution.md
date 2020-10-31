## My Solution

### C#

```csharp
using System;

class Solution
{
    public static int[] SortKMessedArray(int[] arr, int k)
    {
      int temp;
      int leftend, length = arr.Length;
      int[] resarr = arr;

      for (byte cur = 0; cur < length; cur++)
      {
        leftend = (cur + k < length) ? cur + k : length - 1;
        for (int i = leftend; i > cur; i--)
        {
          if (resarr[i] < resarr[cur])
          {
            temp = resarr[cur];
            resarr[cur] = resarr[i];
            resarr[i] = temp;
          }
        }
      }
      return resarr;
    }

    static void Main(string[] args) {   }

```

### - Test Cases

- Test Case #1
  - Input: [1], 0,
  - Expected: [1]
- Test Case #2
  - Input: [1,0], 1,
  - Expected: [0,1]
- Test Case #3
  - Input: [1,0,3,2], 1,
  - Expected: [0,1,2,3]
- Test Case #4
  - Input: [1,0,3,2,4,5,7,6,8], 1,
  - Expected: [0,1,2,3,4,5,6,7,8]
- Test Case #5
  - Input: [1,4,5,2,3,7,8,6,10,9], 2,
  - Expected: [1,2,3,4,5,6,7,8,9,10]
- Test Case #6
  - Input: [6,1,4,11,2,0,3,7,10,5,8,9], 6,
  - Expected: [0,1,2,3,4,5,6,7,8,9,10,11]
