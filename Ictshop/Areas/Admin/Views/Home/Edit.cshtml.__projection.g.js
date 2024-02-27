/* BEGIN EXTERNAL SOURCE */

/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

/* END EXTERNAL SOURCE */
/* BEGIN EXTERNAL SOURCE */

    $(function () {
        $("#chonDuongDanAnh").click(function () {
            var ckfiner = new CKFinder();
            ckfiner.selectActionFunction = function (fileUrl) {
                $("#Anhbia").val(fileUrl);
            };
            ckfiner.popup();
        })
    });
    var ckeditor;
    function createEditor(languageCode, id) {
        var editor = CKEDITOR.replace(id, { language: languageCode });
    }
    $(function () { createEditor('vi', 'Mo') });

/* END EXTERNAL SOURCE */
