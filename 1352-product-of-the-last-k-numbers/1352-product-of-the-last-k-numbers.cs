public class ProductOfNumbers {
    List<int> nums;
    int[] prods;
    public ProductOfNumbers() {
        nums = new List<int>();
    }
    
    public void Add(int num) {
        nums.Add(num);
        prods = new int[nums.Count];
        prods[^1] = num;
        for(int i = nums.Count - 2 ; i >= 0; i--){
            prods[i] = prods[i+1]*nums[i];
        }
    }
    
    public int GetProduct(int k) {
        return prods[prods.Length-k];
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */