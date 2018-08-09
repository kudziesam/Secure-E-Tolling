from flask import Flask, render_template, flash, request
from flask.wtforms.flask_wtf import Form
from flask.wtforms.flask_wtf import validators
from flask.wtforms.flask_wtf.recaptcha.fields import StringField, SubmitField, TextField, TextAreafield

# App config.
DEBUG = True
app = Flask(__name__)
app.config.from_object(__name__)
app.config['SECRET_KEY'] = '7d441f27d441f27567d441f2b6176a'


class ReusableForm(Form):
    date_of_employment = TextField('Date of Employment:', validators=[validators.required(), validators.Length(min=6, max=35)])
    PF_No = TextField('PF No:', validators=[validators.required(), validators.Length(min=6, max=35)])
    first_name = TextField('first name:', validators=[validators.required(), validators.Length(min=3, max=35)])
    middle_name = TextField('middle name:', validators=[validators.required(), validators.Length(min=3, max=35)])
    last_name = TextField('last name:', validators=[validators.required(), validators.Length(min=6, max=35)])
    address = TextField('address:', validators=[validators.required(), validators.Length(min=3, max=35)])
    date_of_birth = TextField('date of birth:', validators=[validators.required(), validators.Length(min=6, max=35)])
    telephone_number = TextField('telephone number:', validators=[validators.required(), validators.Length(min=3, max=35)])
    email_address = TextField('email address:', validators=[validators.required(), validators.Length(min=6, max=35)])
    place_of_birth = TextField('place of birth:', validators=[validators.required(), validators.Length(min=3, max=35)])
    gender = TextField('gender:', validators=[validators.required(), validators.Length(min=6, max=35)])
    nationality = TextField('nationality:', validators=[validators.required(), validators.Length(min=3, max=35)])
    marital_status = TextField('marital status:', validators=[validators.required(), validators.Length(min=6, max=35)])
    proof_of_marriage = TextField('documentary proof of marriage(yes/no):', validators=[validators.required(), validators.Length(min=3, max=35)])
    Passport_No = TextField('passport No:', validators=[validators.required(), validators.Length(min=6, max=35)])
    Issuing_date = TextField('issuing date:', validators=[validators.required(), validators.Length(min=3, max=35)])
    Expiry_Date = TextField('Expiry Date:', validators=[validators.required(), validators.Length(min=6, max=35)])
    TIN = TextField('TIN(Tax Identification No):', validators=[validators.required(), validators.Length(min=3, max=35)])
    NSSF_No = TextField('NSSF No:', validators=[validators.required(), validators.Length(min=6, max=35)])
    Contract_Start_Date = TextField('Contract Start Date:', validators=[validators.required(),
                                                                        validators.Length(min=3, max=35)])
    Contract_Expiry_Date = TextField('Contract Expiry Date:', validators=[validators.required(), validators.Length(min=6, max=35)])
    Employee_Status = TextField('Employee Status(Contract, temporary):', validators=[validators.required(),
                                                                                     validators.Length(min=3, max=35)])
    Contract_Duration = TextField('Contract Duration:', validators=[validators.required(), validators.Length(min=6, max=35)])
    Job_Designation = TextField('Job Designation:', validators=[validators.required(), validators.Length(min=3, max=35)])
    Department = TextField('Department:', validators=[validators.required(), validators.Length(min=6, max=35)])
    Name_of_Current_Supervisor = TextField('Name of Current Supervisor:', validators=[validators.required(), validators.Length(min=3, max=35)])
    Job_Location = TextField('Job Location:', validators=[validators.required(), validators.Length(min=6, max=35)])
    Do_you_have_any_disabilities = TextField('Do you have any disabilities(yes/no):', validators=[validators.required(), validators.Length(min=3, max=35)])
    Full_Name_Of_Spouse = TextField('Full Name Of Spouse:', validators=[validators.required(), validators.Length(min=6, max=35)])
    spouses_Nationality = TextField('spouses nationality:', validators=[validators.required(), validators.Length(min=3, max=35)])
    name_of_next_of_kin = TextField('name of next of kin:', validators=[validators.required(), validators.Length(min=6, max=35)])
    contact_address_of_next_of_kin = TextField('contact address of next of kin:', validators=[validators.required(), validators.Length(min=3, max=35)])
    relationship_with_next_of_kin = TextField('relationship with next of kin:', validators=[validators.required(), validators.Length(min=6, max=35)])
    biological_children = TextField('biological children:', validators=[validators.required(), validators.Length(min=3, max=35)])
    fullname_of_father = TextField('fullname of father:', validators=[validators.required(), validators.Length(min=6, max=35)])
    physical_address = TextField('physical address:', validators=[validators.required(), validators.Length(min=6, max=35)])
    fullname_of_mother = TextField('fullname of mother:', validators=[validators.required(), validators.Length(min=6, max=35)])
    primary_contact_last_name = TextField('primary contact last name:', validators=[validators.required(), validators.Length(min=6, max=35)])
    primary_contact_first_name = TextField('primary contact first name:', validators=[validators.required(), validators.Length(min=6, max=35)])
    primary_contact_relationship = TextField('primary contact relationship:', validators=[validators.required(), validators.Length(min=6, max=35)])
    primary_contact_address = TextField('primary contact address:', validators=[validators.required(), validators.Length(min=6, max=35)])
    primary_contact_telephone = TextField('primary contact telephone:', validators=[validators.required(), validators.Length(min=6, max=35)])
    secondary_contact_last_name = TextField('secondary contact last name:',validators=[validators.required(), validators.Length(min=6, max=35)])
    secondary_contact_first_name = TextField('secondary contact first name:',validators=[validators.required(), validators.Length(min=6, max=35)])
    secondary_contact_relationship = TextField('secondary contact relationship:', validators=[validators.required(), validators.Length(min=6, max=35)])
    secondary_contact_address = TextField('secondary contact address:', validators=[validators.required(), validators.Length(min=6, max=35)])
    secondary_contact_telephone = TextField('secondary contact telephone:',validators=[validators.required(), validators.Length(min=6, max=35)])
    dependants_full_names = TextField('dependants full names:', validators=[validators.required(), validators.Length(min=6, max=100)])
    dependants_relationship = TextField('dependants relationship:', validators=[validators.required(), validators.Length(min=6, max=100)])
    dependants_nationality = TextField('dependants nationality:', validators=[validators.required(), validators.Length(min=6, max=100)])
    dependants_occupation = TextField('dependants occupation:', validators=[validators.required(), validators.Length(min=6, max=100)])
    dependants_present_address = TextField('dependants present address:', validators=[validators.required(), validators.Length(min=6, max=100)])
    relatives_at_ucc = TextField('relatives at ucc:', validators=[validators.required(), validators.Length(min=3, max=35)])
    course = TextField('course:', validators=[validators.required(), validators.Length(min=3, max=35)])
    institution = TextField('institution:', validators=[validators.required(), validators.Length(min=3, max=35)])
    provisional_completion_date = TextField('provisional completion date:', validators=[validators.required(), validators.Length(min=3, max=35)])
    position = TextField('position:', validators=[validators.required(), validators.Length(min=3, max=35)])
    organisation = TextField('organisation:', validators=[validators.required(), validators.Length(min=3, max=35)])
    duration = TextField('duration:', validators=[validators.required(), validators.Length(min=3, max=35)])
    discharged_or_forced_to_resign = TextField('discharged or forced to resign:', validators=[validators.required(), validators.Length(min=3, max=35)])
    reference_name = TextField('reference name:', validators=[validators.required(), validators.Length(min=3, max=35)])
    reference_full_address = TextField('reference full address:', validators=[validators.required(), validators.Length(min=3, max=35)])
    reference_occupation = TextField('reference occupation:', validators=[validators.required(), validators.Length(min=3, max=35)])
    other_details = TextField('other details:', validators=[validators.required(), validators.Length(min=3, max=35)])
    arrested_or_detained = TextField('arrested or detained:', validators=[validators.required(), validators.Length(min=3, max=35)])
    date = TextField('date:', validators=[validators.required(), validators.Length(min=3, max=35)])


@app.route("/", methods=['GET', 'POST'])
def hello():
    form = ReusableForm(request.form)

    print
    form.errors
    if request.method == 'POST':
        date_of_employment = request.form['Date of Employment']
        PF_No = request.form['PF No']
        first_name = request.form['first name']
        middle_name = request.form['middle name']
        last_name = request.form['last name']
        address = request.form['address']
        date_of_birth = request.form['date of birth']
        telephone_number = request.form['telephone number']
        email_address = request.form['email address']
        place_of_birth = request.form['place of birth']
        gender = request.form['gender']
        nationality = request.form['nationality']
        marital_status = request.form['marital status']
        proof_of_marriage = request.form['documentary proof of marriage(yes/no)']
        Passport_No = request.form['passport No']
        Issuing_date = request.form['issuing date']
        Expiry_Date = request.form['Expiry Date']
        TIN = request.form['TIN(Tax Identification No)']
        NSSF_No = request.form['NSSF No']
        Contract_Start_Date = request.form['Contract Start Date']
        Contract_Expiry_Date = request.form['Contract Expiry Date']
        Employee_Status = request.form['Employee Status(Contract, temporary)']
        Contract_Duration = request.form['Contract Duration']
        Job_Designation = request.form['Job Designation']
        Department = request.form['Department']
        Name_of_Current_Supervisor = request.form['Name of Current Supervisor']
        Job_Location = request.form['Job Location']
        Do_you_have_any_disabilities = request.form['Do you have any disabilities(yes/no)']
        Full_Name_Of_Spouse = request.form['Full Name Of Spouse']
        spouses_Nationality = request.form['spouses nationality']
        name_of_next_of_kin = request.form['name of next of kin']
        contact_address_of_next_of_kin = request.form['contact address of next of kin']
        relationship_with_next_of_kin = request.form['relationship with next of kin']
        biological_children = request.form['biological children']
        fullname_of_father = request.form['fullname of father']
        physical_address = request.form['physical address']
        fullname_of_mother = request.form['fullname of mother']
        primary_contact_last_name = request.form['primary contact last name']
        primary_contact_first_name = request.form['primary contact first name']
        primary_contact_relationship = request.form['primary contact relationship']
        primary_contact_address = request.form['primary contact address']
        primary_contact_telephone = request.form['primary contact telephone']
        secondary_contact_last_name = request.form['secondary contact last name']
        secondary_contact_first_name = request.form['secondary contact first name']
        secondary_contact_relationship = request.form['secondary contact relationship']
        secondary_contact_address = request.form['secondary contact address']
        secondary_contact_telephone = request.form['secondary contact telephone']
        dependants_full_names = request.form['dependants full names']
        dependants_relationship = request.form['dependants relationship']
        dependants_nationality = request.form['dependants nationality']
        dependants_occupation = request.form['dependants occupation']
        dependants_present_address = request.form['dependants present address']
        relatives_at_ucc = request.form['relatives at ucc']
        course = request.form['course']
        institution = request.form['institution']
        provisional_completion_date = request.form['provisional completion date']
        position = request.form['position']
        organisation = request.form['organisation']
        duration = request.form['duration']
        discharged_or_forced_to_resign = request.form['discharged or forced to resign']
        reference_name = request.form['reference name']
        reference_full_address = request.form['reference full address']
        reference_occupation = request.form['reference occupation']
        other_details = request.form['other details']
        arrested_or_detained = request.form['arrested or detained']
        date = request.form['date']

        print
        date_of_employment, "", PF_No, "", first_name, " ", middle_name, " ", last_name, "", address, "", date_of_birth,\
        "", telephone_number, "", email_address, "", place_of_birth, "", gender, "", nationality, "", marital_status, "",
        proof_of_marriage, "", Passport_No, "", Issuing_date, "", Expiry_Date, "", TIN, "", NSSF_No, "", Contract_Start_Date, "", Contract_Expiry_Date, "",
        Employee_Status, "", Contract_Duration, "", Job_Designation, "", Department, "", Name_of_Current_Supervisor, "", Job_Location, "",
        Do_you_have_any_disabilities, "", Full_Name_Of_Spouse, "", spouses_Nationality, "", name_of_next_of_kin, "", contact_address_of_next_of_kin, "",
        relationship_with_next_of_kin, "", biological_children, "", fullname_of_father, "", physical_address, "", fullname_of_mother, "",
        primary_contact_last_name, "", primary_contact_first_name, "", primary_contact_relationship, "", primary_contact_address, "",
        primary_contact_telephone, "", secondary_contact_last_name, "", secondary_contact_first_name, "", secondary_contact_relationship, "",
        secondary_contact_address, "", secondary_contact_telephone, "", dependants_full_names, "", dependants_relationship, "",
        dependants_nationality, "", dependants_occupation, "", dependants_present_address, "", relatives_at_ucc, "", course, "", institution, "",
        provisional_completion_date, "", position, "", organisation, "", duration, "", discharged_or_forced_to_resign, "", reference_name, "",
        reference_full_address, "", reference_occupation, "", other_details, "", arrested_or_detained, "", date


        if form.validate():
            # Save the comment here.
            flash('Thanks for registration ' + first_name)
        else:
            flash('Error: All the form fields are required. ')

    return render_template('registeremployee.html', form=form)


if __name__ == "__main__":
    app.run()