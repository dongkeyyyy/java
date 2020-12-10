
public class Yeondong {

	public static void main(String[] args) {
		// IDE를 git과 연동하여 IDE에서 바로 commit&push
		System.out.println("숙제량이 상당하다 이 말이야");
		
		String str = "숙제량이";
		String str1 = "상당하다";
		
		System.out.println(str + str1);
		
		String str3 = "Good Morning";
		
		System.out.println("charat : " + str3.charAt(6));
		System.out.println("replace : " + str3.replace("Good" , "a"));
		System.out.println("replace : " + str3.replace("[Good]", "a"));
		System.out.println("replaceall : " + str3.replace("Good" , "a"));
		System.out.println("replaceall : " + str3.replace("[Good]" , "a"));
		
		
		System.out.println("이클립립스와 깃허브 데스크탑 연동");
		
		int a = 384;
		int b = 472;
		
		System.out.println("1 : " + a*(b%10));
		System.out.println("2 : " + a*(b%100/10));
		System.out.println("3 : " + a*(b/100));
		System.out.println("4 : " + a*b);
		System.out.println();
		
		
	}

}
