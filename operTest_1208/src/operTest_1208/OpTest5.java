package operTest_1208;

public class OpTest5 {

	public static void main(String[] args) {
		// 3항 연산자 10 + 2 에서 10과 2를 항이라고 부른다. 10+2 = 항이 2개이므로 이항 연산자라고 부름  루트4= 단항 연산자
		// 변수에 괄호가 있으면 무조건 메쏘드이다.
		// 메쏘드 안에서 선언된 변수에 초기값이 
		// 없으면 쓰레기값이 들어감.
		int num1 = 10;
		int num2 = 15;
		String str = "";
		str = (++num1 >= num2) ? "num1이 크다" : "num2가 크다";  // ++num1 = 10+1이므로 11.  11>=15 = false .   true면 "num1이 크다"가 동작을 하고 false면 "num2가 크다"가 동작이 됨
		System.out.println(str);

	}

}
