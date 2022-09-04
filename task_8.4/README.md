# Задание 4. Записная книжка


## Что нужно сделать
Программа спрашивает у пользователя данные о контакте:

- ФИО
- Улица
- Номер дома
- Номер квартиры
- Мобильный телефон
- Домашний телефон


С помощью [XElement](https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement?view=net-6.0) создайте xml файл, в котором есть введенная информация. XML файл должен содержать следующую структуру:

```
<Person name=”ФИО человека” >
    <Address>
        <Street>Название улицы</Street>
        <HouseNumber>Номер дома</HouseNumber>
        <FlatNumber>Номер квартиры</FlatNumber>
    </Address>
    <Phones>
        <MobilePhone>89999999999999</MobilePhone>
        <FlatPhone>123-45-67<FlatPhone>
    </Phones>
</Person>
```

## Советы и рекомендации
Заполняйте [XElement](https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement?view=net-6.0) в ходе заполнения данных. Изучите возможности XElement в документации Microsoft.



## Что оценивается
Программа создаёт Xml файл, содержащий все данные о контакте.
