import math

# task 1
x = input('Print x: ')
y = input('Print y: ')
x = int(x)
y = int(y)
z = 0
if y < 10:
    z = x*y + y
else:
    z = x + y**math.exp(1)
print("1. Result is %d" %(z))

# task 2
while x != 0 and y != 0:
    if x > y:
        x %= y
    else:
        y %= x
res = x + y
print("2. Result is %d" %(res))

# task 3
A = [[1, 4, -2, 5, -6, 8], 
    [-5, 8, 0, 9, 7, -11],
    [-8, -3, 7, 8, 9, 3],
    [0, -9, 7, -4, -1, 15]]
result = [0, 0, 0, 0]
for i in range(4):
    result[i] = max(A[i])
print("3. " + str(result))