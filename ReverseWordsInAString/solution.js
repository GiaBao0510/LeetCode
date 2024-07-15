var reverseWords = function(s) {

    let word = '';
    let StringArr = [];

    //Đưa vào một vòng lặp các ký tự trong một chuỗi 
    for(let i = 0; i <s.length; i++){
        word += s[i];

        //Nếu gặp khoảng trống thì thêm mới word và mảng và làm mới word
        if(s.charCodeAt(i) === 32){
            if(word.charCodeAt(0) !=32 ){
                word = word.trim();
                StringArr.push(word);
            }
            word = '';
        }
        //Nếu cuối chuỗi mà không phải là khoảng trống thì được phép thêm
        if(s.charCodeAt(i) != 32 && i == s.length-1 ){
            StringArr.push(word);
        }
    }

    //Chuyển đổi ngược lại
    let result = '';
    for(let k = StringArr.length-1; k >=0 ; k--){
        result+=StringArr[k];

        //Nếu k chưa  == 0 thì thêm
        if(k!= 0){
            result+=" ";
        }
    }
    return result;
};
reverseWords('  hello world  ');