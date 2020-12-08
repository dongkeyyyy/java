package operTest_1208;

public class For {

	public static void main(String[] args) {
	
  // 1단부터 4단까지의 구구단 식
  // for 첫번째에 변수 a1 = 행,  2번째의 변수 a2 = 열
  // 2번째 for이 a2<10 조건에 만족하지 못할때까지 a1 = 1 인채로 계속 곱셈이 됨 
  // a2가 9까지 곱셈을 했으면 for 첫번쨰 문장으로 돌아와서 a1++ 때문에 a1=2가 됨 그리고 구구단 2단 시작  . 4단까지 반복
		for(int a1 = 1; a1 < 5; a1++)  {
			for(int a2 = 1; a2 < 10; a2++) {
				
        
				System.out.printf(a1 + "*" + a2 + "=" + (a1*a2));
				
				System.out.println("");
			}
		}
	}

}

