# Final project
## DA
 包含sensor以及node-red，首先node-red要開啟，進行GSCL的application插入
 開啟sensor，選定要傳送的資料，藉由node-red傳到GSCL
## NA
 需要安裝flask和python3.5以上版本
 執行python hmmmodel.py
 執行python server.py
 會直接進行GSCL的訂閱，如果已訂閱過過出現conflict的警告，不影響執行
 flask的預設port為5000，後面則是由寫定的程式決定
 此project中，查看活動的介面為127.0.0.1:5000/check
	
    
