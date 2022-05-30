
    GridGetir();
    function GridGetir() {

        $.ajax({
            type: "POST",
            url: "/Home/GetCount",
            success: function (data) {
                GridDoldur(data);
                console.log(data);
            },
            error: function (xhr) {
                OnErrorEx(xhr);
            }
        });

    }

    function GridDoldur(data) {
        result = data;
    /*console.log(result);*/


    function logEvent(eventName) {
            const logList = $('#events ul');
    const newItem = $('<li>', {text: eventName });

        logList.prepend(newItem);
        }


        var grid = $('#gridContainer').dxDataGrid({
            dataSource: result,
        key: 'id',
        showBorders: true,
        columnAutoWidth: true,
        allowColumnResizing: true,
        showRowLines: true,
        headerFilter: {visible: true },
        filterRow: {visible: true },
        searchPanel: {visible: true },

        paging: {
            pageSize: 15
            },
        selection: {
            mode: 'multiple',
            },

        pager: {
            showPageSizeSelector: true,
        allowedPageSizes: [15, 30, 50, 100, 500],
        showNavigationButtons: true
            },
        editing: {
            mode: 'row',
        allowUpdating: true,
        allowDeleting: true,
        allowAdding: true,
            },

            //onContentReady: function (e) {
            //    e.component.columnOption("command:edit", "visibleIndex", -1);
            //},
            columns: [
        {
            dataField: "id",
        width: 40,
        cssClass: 'cls',
        visible: false,
        allowHeaderFiltering: true,
                },
        {
            dataField: "gonderimTarihi",
        caption: "Gönder~im",
        dataType: "datetime",
        format: "HH:mm:ss",
        editorOptions: {
            useMaskBehavior: true
                    },
        alignment: "left",
        width: 70,
        cssClass: 'cls',
        allowHeaderFiltering: false
                },
        {
            dataField: "lokasyonAdi",
        caption: "Lokasyon Adı",
        validationRules: [{type: 'required' }],
        alignment: "left",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "lokasyonDurumu",
        caption: "Lokasyon Durumu",
        alignment: "left",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "okumaTarihi",
        caption: "Okuma Saati",
        dataType: "datetime",
        format: "HH:mm:ss",
        editorOptions: {
            useMaskBehavior: true
                    },
        alignment: "left",
        width: 120,
        cssClass: 'cls',
        allowHeaderFiltering: false
                },
        {
            dataField: "okuyanAdi",
        caption: "Personel Adı",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "okuyanSoyadi",
        caption: "Personel Soyadı",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "sayimDurumu",
        caption: "Durumu",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "sayimMiktari",
        caption: "Miktar",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "sonKullanimTarihi",
        caption: "Son Kullanma Tarihi",
        dataType: "datetime",

        editorOptions: {
            useMaskBehavior: true
                    },
        alignment: "left",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: false
                },
        {
            dataField: "stokKodu",
        validationRules: [{type: 'required' }],
        caption: "Stok Kodu",
        width: 100,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },

        {
            dataField: "stokMiktari",
        caption: "Stok Miktarı",
        validationRules: [{type: 'required' }],
        alignment: "left",
        width: 120,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "terminalAdi",
        caption: "Terminal Adı",
        validationRules: [{type: 'required' }],
        alignment: "left",
        width: 120,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "terminalID",
        caption: "Terminal ID",

        alignment: "left",
        width: 120,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {
            dataField: "terminalIpAdresi",
        caption: "Terminal Ip Adresi",

        alignment: "left",
        width: 120,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {

            dataField: "urunAciklamasi",
        caption: "Ürün Açıklaması",
        Unit: [{type: 'required' }],
        alignment: "left",
        width: 80,
        cssClass: 'cls',
        allowHeaderFiltering: true
                },
        {

            dataField: "urunAdi",
        caption: "Ürün Adı",
        Unit: [{type: 'required' }],
        alignment: "left",
        width: 80,
        cssClass: 'cls',
        allowHeaderFiltering: true
                }
        ],

        onEditingStart(e) {
            logEvent('EditingStart');
                /*   alert(e.component.getRowIndexByKey(e.key));*/

            },
        onInitNewRow() {

        },
        onRowInserting() {
        },



        /*Yapıldı Insert*/
        onRowInserted(e) {
            logEvent('RowInserted');

        //console.log(e.key);

        source = e.key;
        $.ajax({
            type: "POST",
        dataType: "json",
        url: "/Home/AddVersiyon",
        data: source,
        success: function () {
            //swal({
            //    title: "Red Alert!",
            //    text: "I will close in 4 seconds.",
            //    timer: 4000,
            //    showConfirmButton: false
            //});
            GridGetir();
                    },
        error: function (xhr) {
            OnErrorEx(xhr);
                    }
                });
        swal("Bir Şeyler Eklendi", "Ekleme Başarılı", "success");

            },

            //onRowRemoving() {
            //},

            ///*Yapıldı Delete*/
            //onRowRemoved(e) {
            //    //   console.log(e.key);

            //    source = e.key;
            //    $.ajax({
            //        type: "POST",
            //        dataType: "json",
            //        url: "/Home/RemoveVersiyon",
            //        data: source,
            //        success: function () {
            //            GridGetir();
            //        },
            //        error: function (xhr) {

            //        }
            //    });
            //    swal("Bir Şeyler Silindi", "Silindi Başarılı", "success");
            //},

            //onSaving(e) {

            //},

            ///*Yapıldı Update*/
            //onRowUpdated(e) {
            //    var source = e.key;
            //    // console.log(source);

            //    $.ajax({
            //        type: "POST",
            //        dataType: "json",
            //        url: "/Home/UpdateVersiyon",
            //        data: source,
            //        success: function () {
            //            GridGetir();
            //        },
            //        error: function (xhr) {
            //            OnErrorEx(xhr);
            //        }
            //    });
            //    swal("Bir Şeyler Güncellendi", "Güncelleme Başarılı", "success");




            //},


            //onSaved(e) {
            //},
            //onEditCanceling() {
            //},
            //onEditCanceled() {
            //},


        }).dxDataGrid("instance");;

        $('#select-all-mode').dxSelectBox({
            dataSource: ['allPages', 'page'],
        value: 'allPages',
        onValueChanged(data) {
            dataGrid.option('selection.selectAllMode', data.value);
            },
        });

    };

