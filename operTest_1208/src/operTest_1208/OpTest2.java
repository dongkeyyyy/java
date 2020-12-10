package operTest_1208;

public class OpTest2 {

	public static void main(String[] args) {
		int num1 = 10;
		int num2 = 0;
		
		// ++, -- 증감연산자
		// 1증가, 1감소
		// ++가 뒤에붙어있으면 이후에 똑같은 변수를 사용할때 증가 ++가 앞에 붙어있으면 바로 증가
		num2 = num1++;
		System.out.println("num2 : " + num2);
		
		num2 = ++num1;
		System.out.println("num2 : " + num2);
		
		// 12--;   ->    --num1을 다시 만나서 1이 감소하고 앞에 붙은 --로 1을 다시 빼서 10이 된다 
		// 처음 num1-- = 12로 적용된다 다음에 num1을 사용하면 11이 되고 --num1이기때문에 1을 더 빼서 10이됨
		num2 = num1--;
		System.out.println("num2 : " + num2);
		
		num2 = --num1;
		System.out.println("num2 : " + num2);

	}

}
