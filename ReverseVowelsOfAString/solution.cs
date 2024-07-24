public class Solution {
     public string ReverseVowels(string s)
 {
     //0. Tạo 2 biến xét duyệt và 1 biến temp
     int L = 0,
         R = s.Length - 1;
     char temp;

     //1.Tạo mảng chứa các nguyên âm
     char[] vowels = { 'u', 'e', 'a', 'i', 'o', 'U', 'E', 'A', 'I', 'O' };

     //2. Chuyển s về mảng ký tự
     char[] ArrS = s.ToCharArray();

     //3. Xét duyệt và đổi chỗ nếu cả 2 ký tự xét duyệt điều là ký tự nguyên âm 
     while(L < R)
     {
         Console.WriteLine("Dang xet: {0} - {1}", ArrS[L], ArrS[R]);
         Console.WriteLine("Xet {0} - la nguyen am: {1}", ArrS[L], Array.Exists(vowels, element => ArrS[L] == element));
         Console.WriteLine("Xet {0} - la nguyen am: {1}", ArrS[R], Array.Exists(vowels, element => ArrS[R] == element));
         //Xét duyệt nếu cả 2 đuêỳ là nguyên âm thì thực hiện
         if (Array.Exists(vowels, element => ArrS[L] == element) == true 
             && Array.Exists(vowels, element => ArrS[R] == element) == true
         ){
             temp = ArrS[L];
             ArrS[L] = ArrS[R];
             ArrS[R] = temp;
             L++; R--;
         }

         //Nếu chỉ giá trị bên L là nguyên mà bên R thì ko thì chỉ giảm R
         else if (Array.Exists(vowels, element => ArrS[L] == element) == true
             && Array.Exists(vowels, element => ArrS[R] == element) == false
         )
         {
             R--;
         }

         //Nếu chỉ giá trị bên R là nguyên mà bên L thì ko thì chỉ tăng L
         else if (Array.Exists(vowels, element => ArrS[L] == element) == false
             && Array.Exists(vowels, element => ArrS[R] == element) == true
         )
         {
             L++;
         }
         else
         {
             L++; R--;
         }
     }

     //Ép mảng ký tự về chuỗi
     s = new string(ArrS);

     Console.WriteLine(s);
     return s;
 }
}