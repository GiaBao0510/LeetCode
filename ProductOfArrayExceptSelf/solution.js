var productExceptSelf = function(nums) {
    //Tạo 2 mảng có cùng kích thước với mảng đầu vào
    let leftArr = [],
        rightArr= [],
        result = [];
    
    //Ban đầu thêm phần tử có giá trị 1 vào 2 mảng trên
    leftArr.push(1);
    rightArr.push(1);

    //1.Thực hiện vòng lặp để tính toán các giá trị từ mảng đầu vào cho mảng leftarray cụ thể như sau:
    for(let i = 0; i< nums.length -1 ;i++){
        /*
            Lấy giá trị cuối cùng của mảng leftArr nhân với giá trị đang xét của mảng nums, 
            rồi lưu lại
        */
        const finalValue = leftArr[leftArr.length - 1]; 
        leftArr.push( nums[i] * finalValue);
    }

    //2. Thực hiện lặp để tính toán các giá trị từ mảng nums, rồi lưu vào mảng rightArray. Cụ thể như sau:
    for(let i = nums.length -1 ; i > 0; i--){
        /*
            Lấy giá trị cuối cùng của mảng rightArr nhân với giá trị đang xét của mảng nums, 
            rồi lưu lại
        */
       const finalValue = rightArr[rightArr.length -1];
       rightArr.push( nums[i] * finalValue);
    }

    //3. Tính toán để tạo ra mảng kết quả, bằng cách nhân vị trí đầu của left với vị trí cuối của right , rồi lần lượt tới
    let dem = 0;
    while(dem <= nums.length -1){
        result.push( leftArr[dem] * rightArr[nums.length -1 - dem]);
        dem++;
    }
    
    return result;
};

productExceptSelf([3,7,8,10]);