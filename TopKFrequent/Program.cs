// See https://aka.ms/new-console-template for more information
Console.Write("asdasd");

int k=1;
int[] nums = new int[]{7,7};
int[] output = TopKFrequent(nums,k);

for(int i=0;i<k;i++)
{
    Console.WriteLine(output[i]);
}

int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> d1 = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!d1.ContainsKey(num))
            {
                d1.Add(num,1);
            }
            else
            d1[num]++;
        }
        int[] output = new int[k];

        for(int i =0; i<k;i++)
        {
            var maxPair= d1.First(x=> x.Value == d1.Values.Max());
            
            output[i] = maxPair.Key;
            d1.Remove(maxPair.Key);
        }
        
        return output;
    }