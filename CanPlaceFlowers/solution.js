var canPlaceFlowers = function(flowerbed, n) {

    let front = 0, back = 0, count = 0;

    //Nếu độ dài lớn hơn 1 thì lặp
    if(flowerbed.length>1){
        for(let i =0; i < flowerbed.length; i++){
            //Nếu duyệt phần tử đầu tiên thì đặt như sau
            if(i == 0){
                
                front = flowerbed[i];
                back = flowerbed[i+1];

                //Kiểm tra phía trước nếu ko liền kề và là 0 thì đến cộng 1
                if(back!=1 &&  front == 0){
                    flowerbed[i] = 1;
                    count++;
                }

            }
            //Nếu duyệt phần tử cuối cùng thì duyệt như sau
            else if(i == flowerbed.length - 1){
                back = flowerbed[i];
                front = flowerbed[i-1];
                flowerbed[i] =1;

                //Kiểm tra nếu duyệt đến phần tử cuỗi, nếu trước nó mà chưa đặt cây thì đặt chỗ đó q chậu cây và tăng lên 1
                if(back ==0 && front == 0){
                    flowerbed[i] = 1;
                    count++;
                }
            }
            //Nếu phần tử ở giữa thì duyệt như sau
            else{
                back = flowerbed[i+1];
                front = flowerbed[i-1];

                //Nếu cả trước và sau điều khác 1 ,nghĩa là chưa phạm quy tắc thì tăng lên
                if(back!=1 && front != 1 && flowerbed[i]== 0){
                    flowerbed[i] = 1;
                    count++;
                }
            }
        }
        
    }
    //Nếu độ dài bằng 1 && chưa có cây thì thêm 1
    else if(flowerbed.length == 1 && flowerbed[0] == 0){
        flowerbed[0] = 1;
        count++;
    }

    //Kiểm tra điều kiện
    if(count >= n){
        return true;
    }else{
        return false;
    }
};
canPlaceFlowers([1,0,1,0,1,0,1],1);