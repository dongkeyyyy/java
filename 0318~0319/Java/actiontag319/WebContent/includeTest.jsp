<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%
    request.setCharacterEncoding("utf-8");
    String pageName = request.getParameter("pageName");
    pageName += ".jsp";
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	포함되는 페이지 : includedTest.jsp
	<jsp:include page="<%=pageName %>"></jsp:include>
</body>
</html>