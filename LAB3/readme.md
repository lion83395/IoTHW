# LAB3_OM2M with Postman
## 目標:
    使用Postman分別建立以下Entities
	1. Create a "MY_SENSOR" Application
		2. Create a "DESCRIPTOR" container
			3. Create a "DESCRIPTOR contentInsances"
		4. Create a "DATA" container
			5. Create a "DATA contentInsances"
			6. Create a "Subscription" contact to localhost:1400/monitor

## 作法or步驟:

1. Create a "MY_SENSOR" Application <br> ![screenshots/postman01.png](screenshots/postman01.png) 
2. Create a "DESCRIPTOR" container <br> ![screenshots/postman02.png](screenshots/postman02.png)
3. Create a "DESCRIPTOR contentInsances" <br> ![screenshots/postman03.png](screenshots/postman03.png)
4. Create a "DATA" container <br> ![screenshots/postman04.png](screenshots/postman04.png)
5. Create a "DATA contentInsances" <br> ![screenshots/postman05.png](screenshots/postman05.png)
6. Create a "Subscription" contact to localhost:1400/monitor <br> ![screenshots/postman06.png](screenshots/postman06.png)
# LAB3_OM2M  GA with Node-red
## 目標:
    使用 node-red 在GSCL分別建立以下 Entities
	1. Create a "MY_SENSOR" Application
		2. Create a "DESCRIPTOR" container
			3. Create a "DESCRIPTOR contentInsances"
		4. Create a "DATA" container
			5. Create a "DATA contentInsances"
	6. 在 GA(node-red) 開啟 /sensorData Server 負責轉傳 data 到 OM2M
	

## 作法or步驟:
          
1. 使用 node-red 在GSCL分別建立以下 Entities <br> ![screenshots/node-red01.png](screenshots/node-red01.png)





# LAB3_OM2M  NA with Node-red
## 目標:
    	

    使用 node-red 在 NSCL 分別建立以下 Entities
	1. Create a "MY_NETWORK_APPLICATION"
	2. Subscribe new contentInsatnace in the   gscl/MYSENSOR/DATA 並儲存
	3. 開啟 /getxmlfile Server 負責讀取先前儲存的資料
    
## 作法or步驟:
   1. 使用 node-red 在NSCL分別建立以下 Entities <br> ![screenshots/node-red02.png](screenshots/node-red02.png)
   結果 <br> ![screenshots/result.png](screenshots/result.png)
