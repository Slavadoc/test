def FillArray():
    _array = []
    print("Введите строку: ")
    _n = input()
    _array.append(_n)
    while (_n != ""):
        print("Если хотите прервать ввод нажмите ENTER или Введите строку: ")
        _array.append(_n)
        _n = input()
    return _array


def SortArray(_array):
    _newArray = []
    for i in range(len(_array)):
        if (len(_array[i]) <= 3):
            _newArray.append(_array[i])
    return _newArray


def PrintArray(_ar):
    str = ""
    for i in range(len(_ar)):
        if i == len(_ar)-1:
            str += (f"\"{_ar[i]}\"")
        else:
            str += (f"\"{_ar[i]}\", ")
    print(str)


array = FillArray()
newArray = SortArray(array)
PrintArray(newArray)
