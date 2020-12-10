import openpyxl

WB = openpyxl.load_workbook("商品リスト.xlsx")
WS = WB["Sheet1"]

WS["A10"] = WS["A1"].value

WB.save("商品リスト.xlsx")

print("Finish")