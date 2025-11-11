class FCFS_Scheduling
{
    static void Main()
    {
        // عدد العمليات
        int n = 4;

        // تعريف العمليات: وقت الوصول ووقت التنفيذ
        int[] arrivalTime = { 0, 4, 2, 3 };
        int[] burstTime = { 5, 3, 8, 6 };
        int[] waitingTime = new int[n];
        int[] turnaroundTime = new int[n];

        // حساب أوقات الانتظار
        waitingTime[0] = 0; // أول عملية لا تنتظر
        for (int i = 1; i < n; i++)
        {
            int sumBurst = 0;
            for (int j = 0; j < i; j++)
            {
                sumBurst += burstTime[j];
            }
            waitingTime[i] = sumBurst - arrivalTime[i];
            if (waitingTime[i] < 0)
                waitingTime[i] = 0; // إذا كانت العملية وصلت بعد انتهاء العملية السابقة
        }

        // حساب أوقات الدوران
        for (int i = 0; i < n; i++)
        {
            turnaroundTime[i] = burstTime[i] + waitingTime[i];
        }

        // عرض النتائج
        Console.WriteLine("Process\tArrival\tBurst\tWaiting\tTurnaround");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"P{i + 1}\t{arrivalTime[i]}\t{burstTime[i]}\t{waitingTime[i]}\t{turnaroundTime[i]}");
        }
    }
}