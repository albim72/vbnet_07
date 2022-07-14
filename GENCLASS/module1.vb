Module Module1

    Sub Main()

        Dim iList As New SimpleList(Of Integer)(2)
        Dim sList As New SimpleList(Of String)(3)
        Dim dList As New SimpleList(Of Date)(2)

        iList.add(11)
        iList.add(24)
        iList.add(56)

        sList.add("czerwony")
        sList.add("lśniący")
        sList.add("dziurawy")
        sList.add("bogaty")

        sList.remove(1)
        dList.add(#2022-04-12#)
        dList.add(#2022-05-22#)
        dList.add(#2022-06-11#)

        Dim si = $"Obiekt SimpleList z 3 wartościami typu Integer(rozmiar: {iList.listLength()}" & vbNewLine &
            $"{iList.listItem(0)} , {iList.listItem(1)}, {iList.listItem(2)}"

        Dim ss = $"Obiekt SimpleList z 4 - 1 wartościami typu String(rozmiar: {sList.listLength()}" & vbNewLine &
            $"{sList.listItem(0)} , {sList.listItem(1)}, {sList.listItem(2)}"

        Dim sd = $"Obiekt SimpleList z 3 wartościami typu Date(rozmiar: {dList.listLength()}" & vbNewLine &
            $"{dList.listItem(0)} , {dList.listItem(1)}, {dList.listItem(2)}"

        Console.WriteLine(si)
        Console.WriteLine(ss)
        Console.WriteLine(sd)

        Console.ReadKey()

    End Sub

End Module
