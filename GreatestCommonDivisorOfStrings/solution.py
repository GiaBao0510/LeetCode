class Solution(object):
    def gcdOfStrings(self, str1, str2):

        #Nếu 2 chuỗi giống nhau thì trả về luôn
        if str1 == str2:
            return str1
        
        #Ngược lại để quy để cắt chuỗi thứ 1
        elif len(str1) > len(str2):

            #lấy phần đầu đã bị kiểm tra. Nếu khác nhau thì trả về rỗng
            getHead = str1[:len(str2)]
            if getHead != str2:
                return ''
            str1 = str1[len(str2):]#Phần cắt đuôi
            return self.gcdOfStrings(str1, str2)
        
        #Ngược lại làm cách thứ 2
        else:
            #Kiểm tra bên chuỗi thứ 1 có bên trong chuỗi thứ 2 hay không
            if str1 in str2:
                str2 = str2[len(str1):]
                return self.gcdOfStrings(str2, str1)
            #Ngược lại đưa về rống
            return ''


str1 = "EFGABC"; str2 = "ABC"
ret = Solution().gcdOfStrings(str1,str2)
print(ret)