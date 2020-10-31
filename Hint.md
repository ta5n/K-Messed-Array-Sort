## K-Messed Array Sort Hint

- Your peer may be tempted to use a standard sorting algorithm such as quicksort or mergesort. However, doing so ignores the fact that the array is nearly-sorted (k-sorted) and yields suboptimal solutions.
- If your peer is stuck, ask them how the fact the array is k-sorted can help divide the array into smaller overlapping chunks (windows) and then sort them in an iterative way.
- This question is a good opportunity to check if your peer remembers Insertion Sort and Heapsort. In general, it’s an opportunity for both of you to brush up on these sorting algorithms. A good source to refresh your memory is the [Sorting Algorithm Article](https://en.wikipedia.org/wiki/Sorting_algorithm) on Wikipedia.
- Watch out for correct calculations and usage of array indices.
- If your peer can’t think of a solution, help their thought process by asking what they can do with a sliding window of size `k+1`.