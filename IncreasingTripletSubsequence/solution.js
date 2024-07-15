var increasingTriplet = function(nums) {

    let I = Number.MAX_VALUE,   //Biến này dùng để giữa giá trị trong mảng nếu thỏa điều kiện 1
        J = Number.MAX_VALUE;   //Biến này dùng để giữa giá trị trong mảng nếu thỏa điều kiện 2

    //Tạo 1 vòng lặp kiểm tra 
    for(let i = 0; i < nums.length ;i ++){

        //Điều kiện thoản mãn là khi số cuối trong mảng > J
        if(nums[i] > J){
            return true;
        }

        //Điều kiện gán giá trị khi giá trụ đang xét >= I hoặc J
        if(nums[i] <= I){
            I = nums[i];
        }
        else if(nums[i] <= J){
            J = nums[i];
        }
        
    }

    console.log('Chưa Thỏa mãn ');
    return false;
};

increasingTriplet([2,4,-2,-3]);