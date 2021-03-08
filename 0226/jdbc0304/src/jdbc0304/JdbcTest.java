package jdbc0304;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JdbcTest {
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&" + "serverTimezone=UTC";

	public static void main(String[] args) {
		connectDB();
		insertDB();
		closeDB();
	}

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver);
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB 접속 성공!");
			}
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void insertDB() {
		String query = "insert into t_user values " + "(0, '홍길동', 100, 'hong@naver.com',"
				+ "'010-1234-1234', '조선 한양 홍대감댁'," + "now())";

		String name = "전우치";
		int age = 200;
		String email = "jon@kakao.com";
		String tel = "010-111-1234";
		String addr = "조선 두메 산골";
		String query2 = String.format("insert into t_user(user_name, user_age," + "email, user_phone, user_addr)"
				+ " values('%s', %d, '%s', '%s', '%s')", name, age, email, tel, addr);

		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void showDB() {
		String query = "select * from t_user";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					System.out.print(count + "\t");
					;
					System.out.print(rs.getString("user_name") + "\t");
					System.out.print(rs.getString("user_age") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.print(rs.getString("user_phone") + "\t");
					System.out.print(rs.getString("user_addr") + "\t");
					System.out.println(rs.getString(6));
					count++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
