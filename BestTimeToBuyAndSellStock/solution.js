var maxProfit = function(prices) {

    let min = prices[0],
        goodProfit = -1;            //Lưu lợi nhuận cổ phiếu bán ra trong ngày có giá tốt nhất

    //Tìm giá nhỏ nhất trong các ngày
    for(let i = 0; i< prices.length; i++){
        if(prices[i] < min && i < prices.length-1 ){ 
            min = prices[i];
            //day = i;
        }

        //So sánh lợi nhuận tốt nhất với giá được tính trong min được
        if(goodProfit < (prices[i]- min) ){
            goodProfit = (prices[i]- min);
        }

    }
    console.log('Lời nhất: ',goodProfit);

    //Nếu không tìm thấy thì trả về 0
    if(goodProfit > 0){
        return goodProfit;
    }
    return 0;
};

maxProfit([7,1,5,3,6,4]);