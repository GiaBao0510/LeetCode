var containsDuplicate = function(nums) {
  //Tạo 1 Map lưu thông tin đã duyệt
    let checked = {};

    //Dùng vòng lặp để duyệt các phần tử
    for(let i =0; i< nums.length; i++){

        //Nếu kiểm tra phần tử này đã tồn tại thì trả về true
        if(nums[i] in checked){
            console.log('True');
            return true;
        }

        //Đánh dấu là giá trị này đã được duyệt rồi
        checked[nums[i]] = 1;
    }

    //Trả về false nếu không tìm thấy
    console.log('False');
    return false;
};

containsDuplicate([1,2,3,4,5,1]);