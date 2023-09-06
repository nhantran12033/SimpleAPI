# SimpleAPI
1. Truy cập vào DbMigrator -> appsettings.json
   - Chỉnh sửa lại ConnectionStrings -> Default trỏ tới Database Local của SqlSever
2. Truy cập vào HttpApi.Host -> appsettings.json
   - Chỉnh sửa lại ConnectionStrings -> Default trỏ tới Database Local của SqlSever
3. Run DbMigrator để kết nối csdl
4. Run HttpApi.Host để chạy API
5. Mở CMD trỏ đến thư mục angular của project, gõ lệnh -> yarn (cài đặt lib) 
6. Sau khi đã cài đặt lib xong, gõ lệnh npm start để chạy frontend
