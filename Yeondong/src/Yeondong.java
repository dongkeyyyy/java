
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
		
		
	}

}
