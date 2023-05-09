nb=int(input()) #nº de bilhetes 
n=int(input()) #nº de amigos

li=[]
for i in range(n):
    a=int(input())
    li.append(a)
lf=[]
for i in li:
    lf.append(0)
    
nami=n

while nb>=nami and nami>=0:
    for i in range(len(lf)):
        if li[i]>lf[i]:
            lf[i]=lf[i]+1
            nb=nb-1
        elif li[i]==lf[i]:
            nami=nami-1

for i in lf:
    print(i)
    
        
