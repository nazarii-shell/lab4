namespace lab4.classes;

static public class Sort
{
    static public void DoubleBubbleSort(Student[] stud, int size){

        int left = 1;
        int right = size-1;

        while (left <= right){

            for(int i = left; i <= right; i++){

                if(stud[i-1].Score > stud[i].Score){
                    Student temp = stud[i];
                    stud[i] = stud[i-1];
                    stud[i-1] = temp;
                }

            }

            right--;

            for(int i = right; i >= left; i--) {
                if (stud[i - 1].Score > stud[i].Score) {
                    Student temp = stud[i];
                    stud[i] = stud[i - 1];
                    stud[i - 1] = temp;
                }

            }

            left++;

        }

    }
    
    static public void DoubleBubbleSort(LinkedList<Student> stud) 
    {
        bool swapped;
        do
        {
            swapped = false;
            var current = stud.First;

            while (current?.Next != null)
            {
                if (current.Value.Score < current.Next.Value.Score)
                {
                    // Swap node values
                    (current.Value, current.Next.Value) = (current.Next.Value, current.Value);
                    swapped = true;
                }
                current = current.Next;
            }
        } while (swapped);
    }
    
    static public void HeapSort(Student[] arr, int n) {
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);
        for (int i = n-1; i>=0; i--) {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            Heapify(arr, i, 0);
        }
    }
    static void Heapify(Student[] arr, int n, int i) {
        int largest = i;
        int left = 2*i + 1;
        int right = 2*i + 2;
        if (left < n && arr[left].Score < arr[largest].Score)
            largest = left;
        if (right < n && arr[right].Score < arr[largest].Score)
            largest = right;
        if (largest != i) {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}