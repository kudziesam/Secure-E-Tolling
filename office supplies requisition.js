function add_fields() {
document.getElementById("myTable").insertRow(0).innerHTML = '<tr><td><textarea name="No"  id="No" style = "resize: none; ' +
    'width:100%;"></textarea></td><td><textarea name="Description"  id="Description" style="resize:none;width: 100%;"></textarea>' +
    '</td ><td><textarea name="quantity"  id="quantity" style="resize:none;width: 100%;"></textarea></td ><td><textarea name="quantity"  ' +
    'id="quantity" style="resize:none;width: 100%;"></textarea></td ><td><textarea name="Signature"  id="Signature" style="resize:none;width: 100%;"></textarea></td >' +
    '<td><textarea name="Remarks"  id="Remarks" style="resize:none;width: 100%;"></textarea></td ></tr>';
}