import pandas as pd
item_list = []
item_no = input("商品番号を入力してください　終了は-1:")
while(int(item_no) != -1):
 item_name = input("商品名を入れてください:")
 item_price = input("価格を入れてください:")
 item_list.append([item_no,item_name,item_price])
 item_no = input("商品番号を入力してください　終了は-1:")
df = pd.DataFrame(item_list,columns=['商品番号','商品名','価格'])
with pd.ExcelWriter("商品リスト.xlsx") as writer:
 df.to_excel(writer,index=False)
print("終了")