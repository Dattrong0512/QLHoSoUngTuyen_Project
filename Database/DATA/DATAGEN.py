#pip install unidecode
import unidecode
######################
import random
from datetime import datetime, timedelta


last_names = ["Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Huỳnh", "Phan", "Vũ", "Võ", "Đặng", "Bùi", "Đỗ", "Hồ", "Ngô", "Dương", "Lý", "Đào", "Đinh", "Trịnh", "Lương", "Mai", "Tô", "Trương", "Hà", "Phùng", "Đoàn", "Trịnh", "Chu", "Tạ", "Thạch", "Tiêu", "Từ", "Thái", "Tăng", "Sơn", "Sử"]
middle_names = ["Văn", "Thị", "Đăng", "Lê", "Hữu", "Bảo", "Minh", "Trung", "Ngọc", "Thuỳ", "Thịnh", "Hải", "Hồng", "Hương", "Hạnh", "Thủy", "Hà", "Hải", "Hưng", "Hùng"]
first_names = ["Anh", "Trang", "Phương", "Thu", "Huy", "Tùng", "Việt", "Nam", "Hoa", "Linh", "Thảo", "Hồng", "Hương", "Hạnh", "Thủy", "Hà", "Hải", "Hưng", "Hùng"]




DIACHI = ['Hà Nội', 'Hồ Chí Minh','Khánh Hòa', 'Tiền Giang', 'Gia lai', 'Bạc Liêu', 'Cà mau', 'Bắc Giang', 'Bắc Ninh', 'Bình Dương', 'Bình Phước', 'Bình Thuận', 'Bình Định', 'Bến Tre', 'Đà Nẵng', 'Đắk Lắk', 'Đắk Nông', 'Đồng Nai', 'Đồng Tháp', 'Hà Nam', 'Hà Tĩnh', 'Hải Dương', 'Hải Phòng', 'Hậu Giang', 'Hòa Bình', 'Hưng Yên', 'Khánh Hòa', 'Kiên Giang', 'Kon Tum', 'Lai Châu', 'Lâm Đồng', 'Lạng Sơn', 'Lào Cai', 'Long An', 'Nam Định', 'Nghệ An', 'Ninh Bình', 'Ninh Thuận', 'Phú Thọ', 'Phú Yên', 'Quảng Bình', 'Quảng Nam', 'Quảng Ngãi', 'Quảng Ninh', 'Quảng Trị', 'Sóc Trăng', 'Sơn La', 'Tây Ninh', 'Thái Bình', 'Thái Nguyên', 'Thanh Hóa', 'Thừa Thiên Huế', 'Tiền Giang', 'Trà Vinh', 'Tuyên Quang', 'Vĩnh Long', 'Vĩnh Phúc', 'Yên Bái']

VITRIUNGTUYEN = ['Nhân viên bán hàng', 'Nhân viên kinh doanh', 'Nhân viên tư vấn', 'Nhân viên marketing', 'Nhân viên quản lý', 'Nhân viên kỹ thuật', 'Nhân viên IT', 'Nhân viên hành chính', 'Nhân viên văn phòng', 'Nhân viên bảo vệ', 'Nhân viên phục vụ', 'Nhân viên thu ngân', 'Nhân viên bảo trì', 'Nhân viên sản xuất', 'Nhân viên vận chuyển', 'Nhân viên dịch vụ', 'Nhân viên chăm sóc khách hàng', 'Nhân viên bảo hiểm', 'Nhân viên kế toán', 'Nhân viên hỗ trợ', 'Nhân viên giáo viên', 'Nhân viên y tế', 'Nhân viên nghệ thuật', 'Nhân viên thể thao']

TINHTRANGPHIEU = ['Đang xử lý', 'Mới nộp', 'Chấp nhận']    

TINHTRANGHOSO = ['Đang xử lý', 'Đã chấp nhận', 'Đã từ chối']
                 
CHUNGCHI = ['Chứng chỉ IELTS', 'Chứng chỉ TOEIC', 'Chứng chỉ TOEFL', 'Chứng chỉ MOS','Chứng chỉ IC3', 'Chứng chỉ LinkedIn', 'Chứng chỉ Coursera', 'Chứng Chỉ Udemy', 'Chứng chỉ OCA'
            , 'Chứng chỉ OCB', 'Chứng chỉ OCM'  ]

BANGCAP = ['Bằng tốt nghiệp tiểu học', 'Bằng tốt nghiệp THCS', 'Bằng tốt nghiệp THPT', 'Bằng cử nhân', 'Bằng thạc sĩ', 'Bằng tiến sĩ']

LOAICTY = ['Công Ty TNHH', 'Công Ty Cổ Phần', 'Tập đoàn']
LINHVUCCTY = ['Y tế', 'Giáo dục', 'Tài chính', 'Bất động sản', 'Thể thao', 'Nghệ thuật', 'Kỹ thuật', 'IT', 'Marketing', 'Quản lý', 'Vận chuyển', 'Dịch vụ', 'Bảo hiểm', 'Kế toán', 'Hỗ trợ', 'Bảo trì', 'Sản xuất', 'Văn phòng', 'Bảo vệ', 'Phục vụ', 'Thu ngân', 'Kinh doanh', 'Bán hàng', 'Tư vấn']
TENCTY2 = ["Anh", "Trang", "Phương", "Thu", "Huy", "Tùng", "Việt", "Nam", "Hoa", "Linh", "Thảo", "Hồng", "Hương", "Hạnh", "Thủy", "Hà", "Hải", "Hưng", "Hùng"]
TENCTY1 = ["Văn", "Thị", "Đăng", "Lê", "Hữu", "Bảo", "Minh", "Trung", "Ngọc", "Thuỳ", "Thịnh", "Hải", "Hồng", "Hương", "Hạnh", "Thủy", "Hà", "Hải", "Hưng", "Hùng"]

TINHTRANGPHIEUDANGKYDN = ['Đang xử lý', 'Mới đăng ký', 'Đã xử lý']

TIEUCHI = [ 'Tốt nghiệp THPT', 'Tốt nghiệp THCS', 'Có bằng tiến sĩ', 'Kinh nghiệm 1 năm trở lên',
           'Kinh nghiệm 2 năm trở lên', 'Kinh nghiệm 3 năm trở lên', 'Kinh nghiệm 5 năm trở lên', 'Kinh nghiệm 10 năm trở lên',
           'có bằng cử nhân', 'có bằng thạc sĩ', 'có bằng tiến sĩ', 'có chứng chỉ IELTS', 'có chứng chỉ TOEIC', 'có chứng chỉ TOEFL',
           'có chứng chỉ Oracle'
            ]

HINHTHUCTT = ['Toàn bộ', 'Từng đợt']

TENCHIENLUOCUUDAI = ['Giảm giá 30%', 'Giảm giá 70%','Giảm giá 20%','Giảm giá 50%',
                      'Tặng voucher 1000000', 'Tặng voucher 500k', 'Tặng voucher 200k', 
                      'Hỗ trợ chi phí ăn ở', 'Hỗ trợ chi phí ăn uống', 'Hỗ trợ các khóa học online miễn phí', 'Hỗ trợ đào tạo nâng cao kỹ năng',       
                      ]

TENHINHTHUC = ['Quảng cáo Banner', 'Quảng cáo Video', 'Quảng cáo Text', 'Quảng cáo Display', 
               'Quảng cáo Remarketing', 'Quảng cáo Search', 'Quảng cáo Social', 'Quảng cáo Native', 
               'Quảng cáo Email', 'Quảng cáo Affiliate', 'Quảng cáo Influencer', 'Quảng cáo PR', 
               'Quảng cáo Event', 'Quảng cáo Sponsorship', 'Quảng cáo Partnership', 'Quảng cáo Co-marketing', 
               'Quảng cáo Product Placement', 'Quảng cáo Branding', 'Quảng cáo Direct', 'Quảng cáo Indirect', 'Quảng cáo Online', 
               'Quảng cáo Offline', 'Quảng cáo TV', 'Quảng cáo Radio', 'Quảng cáo Print', 'Quảng cáo Outdoor', 'Quảng cáo Mobile',
                 'Quảng cáo Social', 'Quảng cáo Search', 'Quảng cáo Display', 'Quảng cáo Remarketing', 'Quảng cáo Video', 'Quảng cáo Native',
                   'Quảng cáo Email', 'Quảng cáo Affiliate', 'Quảng cáo Influencer', 'Quảng cáo PR', 'Quảng cáo Event', 'Quảng cáo Sponsorship',
                     'Quảng cáo Partnership', 'Quảng cáo Co-marketing', 'Quảng cáo Product Placement', 'Quảng cáo Branding', 'Quảng cáo Direct', 
                     'Quảng cáo Indirect', 'Quảng cáo Online', 'Quảng cáo Offline', 'Quảng cáo TV', 'Quảng cáo Radio', 'Quảng cáo Print', 'Quảng cáo Outdoor', 
                     'Quảng cáo Mobile', 'Quảng cáo Social', 'Quảng cáo Search', 'Quảng cáo Display', 'Quảng cáo Remarketing', 'Quảng cáo Video', 'Quảng cáo Native', 
                     'Quảng cáo Email', 'Quảng cáo Affiliate', 'Quảng cáo Influencer', 'Quảng cáo PR', 'Quảng cáo Event', 'Quảng cáo Sponsorship', 'Quảng cáo Partnership', 
                     'Quảng cáo Co-marketing', 'Quảng cáo Product Placement', 'Quảng cáo Branding', 'Quảng cáo Direct', 'Quảng cáo']


def pick_random_elements(array):
    n = len(array)
    k = random.randint(1, n-1)  # Chọn số lượng phần tử ngẫu nhiên từ 1 đến n-1
    return random.sample(array, k)

def random_phone_num_generator():
    first = str(random.randint(100, 999))
    second = str(random.randint(1, 888)).zfill(3)
    last = (str(random.randint(1, 9998)).zfill(4))
    while last in ['1111', '2222', '3333', '4444', '5555', '6666', '7777', '8888']:
        last = (str(random.randint(1, 9998)).zfill(4))
    return '{}{}{}'.format(first, second, last)

def writefile(filename,sql_insert):
    with open(filename, 'w', encoding='utf-8') as f:
        f.write(sql_insert)


def generate_strings(prefix,count):
    uv_strings = []
    for i in range(1, count + 1):
        uv_string = prefix + str(i).zfill(3)  # Zfill adds leading zeros to ensure the string has at least 3 digits
        uv_strings.append(uv_string)
    return uv_strings

def remove_vietnamese_diacritics(text):
    return unidecode.unidecode(text)

soluong_bang = 1
soluong_chungchi = 1

ungvien_size = 400
nhanvien_size = 400
phieuungtuyen_size = 100
hosoungtuyen_size = phieuungtuyen_size
chitiethoso_size = hosoungtuyen_size
doanhnghiep_size = 400
phieudangkydoanhnghieo_size = 100
phieudangtuyen_size = 100
hoadon_size = phieudangtuyen_size
chienluocuudai_size = 20
banlanhdao_size = 20

danhsachgiahan_size = 100
chitietgiahan_size = danhsachgiahan_size
hinhthuc_size = TENHINHTHUC.__len__()
phieudangkyquangcao_size = 100



SQL_UNGVIEN_INSERT = ''
ungvien = []
for i in range (ungvien_size):
    SQL_uv1 = '''INSERT INTO ADMIN.UNGVIEN '''
    SQL_uv2 = 'VALUES ('


    ma_ung_vien = generate_strings("UV",ungvien_size)[i]
    firstname = random.choice(first_names)
    lastname = random.choice(last_names)
    midname = random.choice(middle_names)


    fullname = lastname + " " + midname + " " + firstname

    sodienthoai = random_phone_num_generator()
    email = remove_vietnamese_diacritics(firstname.lower()) + remove_vietnamese_diacritics(lastname.lower()) + remove_vietnamese_diacritics(midname.lower()) + "@gmail.com"

    diachi = random.choice(DIACHI)
    matkhau = "UV123"

    ungvien.append([ma_ung_vien, fullname, sodienthoai, email, diachi, matkhau])

    SQL_uv2 += f'\'{ma_ung_vien}\', N\'{fullname}\', {sodienthoai}, \'{email}\', N\'{diachi}\', \'{matkhau}\');\n'
    SQL_UNGVIEN_INSERT += SQL_uv1 + SQL_uv2


SQL_NHANVIEN_INSERT = ''
nhanvien = []

for i in range (nhanvien_size):
    SQL_nv1 = '''INSERT INTO ADMIN.NHANVIEN '''
    SQL_nv2 = 'VALUES ('

    ma_nhan_vien = generate_strings("NV",nhanvien_size)[i]
    firstname = random.choice(first_names)
    lastname = random.choice(last_names)
    midname = random.choice(middle_names)

    fullname = lastname + " " + midname + " " + firstname
    sodienthoai = random_phone_num_generator()
    email = remove_vietnamese_diacritics(firstname.lower()) + remove_vietnamese_diacritics(lastname.lower()) + remove_vietnamese_diacritics(midname.lower()) + ".staff@gmail.com"
    matkhau = "NV456"

    nhanvien.append([ma_nhan_vien, fullname, sodienthoai, email, matkhau])

    SQL_nv2 += f'\'{ma_nhan_vien}\', N\'{fullname}\', {sodienthoai}, \'{email}\', \'{matkhau}\');\n'
    SQL_NHANVIEN_INSERT += SQL_nv1 + SQL_nv2



SQL_PHIEUUNGTUYEN_INSERT = ''
phieuungtuyen = []
for i in range (phieuungtuyen_size):

    SQL_put1 = '''INSERT INTO ADMIN.PHIEUUNGTUYEN '''
    SQL_put2 = 'VALUES ('

    maphieuungtuyen  = generate_strings("PUT",phieuungtuyen_size)[i]
    vitriungtuyen = random.choice(VITRIUNGTUYEN)
    tinhtrang = random.choice(TINHTRANGPHIEU)
    maungvien = random.choice(ungvien)[0]
    manhanvien = random.choice(nhanvien)[0]

    phieuungtuyen.append([maphieuungtuyen, vitriungtuyen, tinhtrang, maungvien, manhanvien])
    SQL_put2 += f'\'{maphieuungtuyen}\', N\'{vitriungtuyen}\', N\'{tinhtrang}\', \'{maungvien}\', \'{manhanvien}\');\n'
    SQL_PHIEUUNGTUYEN_INSERT += SQL_put1 + SQL_put2


SQL_HOSOUNGTUYEN_INSERT = ''
hosoungtuyen = []

for i in range (hosoungtuyen_size):
    SQL_hs1 = '''INSERT INTO ADMIN.HOSOUNGTUYEN '''
    SQL_hs2 = 'VALUES ('

    mahosoungtuyen = generate_strings("HS",phieuungtuyen_size)[i]
    maphieuungtuyen = phieuungtuyen[i][0]

    start_date = datetime(2022, 1, 1)
    end_date = datetime(2024, 6, 30)

    ngaynop = start_date + (end_date - start_date) * random.random()
    
    tinhtranghs = random.choice(TINHTRANGHOSO)

    hosoungtuyen.append([mahosoungtuyen, ngaynop, tinhtranghs, maphieuungtuyen])
    SQL_hs2 += f'\'{mahosoungtuyen}\', to_date(\'{ngaynop.strftime("%Y-%m-%d")}\',\'YYYY-MM-DD\'), N\'{tinhtranghs}\', \'{maphieuungtuyen}\');\n'
    SQL_HOSOUNGTUYEN_INSERT += SQL_hs1 + SQL_hs2

SQL_CHITIETHOSO_INSERT = ''
chitiethoso = []

for i in range (chitiethoso_size):
    SQL_cths1 = '''INSERT INTO ADMIN.CHITIETHOSO '''
    SQL_cths2 = 'VALUES ('

    stt = i + 1
    mahosoungtuyen = hosoungtuyen[i][0]
    chungchi = []
    bangcap = []
    loaihoso = []
    for i in range(soluong_bang):
        bangcap.append(random.choice(BANGCAP))
    for i in range(soluong_chungchi):
        chungchi.append(random.choice(CHUNGCHI))
    
    for j in range(soluong_bang):
        chitiethoso.append([1 , "Bằng cấp", bangcap[j], mahosoungtuyen])
    for j in range(soluong_chungchi):
        chitiethoso.append([2 , "Chứng chỉ", chungchi[j], mahosoungtuyen])

    for j in range (soluong_bang):
        SQL_cths2 += f'{1}, N\'Bằng cấp\', N\'{bangcap[j]}\', \'{mahosoungtuyen}\');\n'
        SQL_CHITIETHOSO_INSERT += SQL_cths1 + SQL_cths2
        SQL_cths2 = ''

    for j in range (soluong_chungchi):
        SQL_cths2 = 'VALUES ('
        SQL_cths2 += f'{2}, N\'Chứng chỉ\', N\'{chungchi[j]}\', \'{mahosoungtuyen}\');\n'
        SQL_CHITIETHOSO_INSERT += SQL_cths1 + SQL_cths2
        SQL_cths2 = ''
    

SQL_DOANHNGHIEP_INSERT = ''
doanhnghiep = []
for i in range (doanhnghiep_size):
    SQL_dn1 = '''INSERT INTO ADMIN.DOANHNGHIEP '''
    SQL_dn2 = 'VALUES ('

    madn = generate_strings("CTY",doanhnghiep_size)[i]
    name =  random.choice(TENCTY1) + " " + random.choice(TENCTY2)  
    tencty = random.choice(LOAICTY) + " " +  random.choice(LINHVUCCTY) + " " + name
    diachi = random.choice(DIACHI)
    masothue = random_phone_num_generator()

    firstname = random.choice(first_names)
    lastname = random.choice(last_names)
    midname = random.choice(middle_names)

    nguoidaidien = lastname + " " + midname + " " + firstname


    email = remove_vietnamese_diacritics(name.lower()).replace(" ", "") + ".company@gmail.com"
    matkhau = "DN789"

    doanhnghiep.append([madn, tencty, masothue, nguoidaidien, diachi, email, matkhau])

    SQL_dn2 += f'\'{madn}\', N\'{tencty}\', \'{masothue}\', N\'{nguoidaidien}\', N\'{diachi}\', \'{email}\', \'{matkhau}\');\n'
    SQL_DOANHNGHIEP_INSERT += SQL_dn1 + SQL_dn2

SQL_PHIEUDANGKYDOANHNGHIEP_INSERT = ''
phieudangkydoanhnghiep = []
for i in range (phieudangkydoanhnghieo_size):

    SQL_pdk1 = '''INSERT INTO ADMIN.PHIEUDANGKYDN '''
    SQL_pdk2 = 'VALUES ('

    maphieudangkydoanhnghiep = generate_strings("PDK",phieudangkydoanhnghieo_size)[i]
    madn = random.choice(doanhnghiep)[0]
    manhanvien = random.choice(nhanvien)[0]
    tinhtrang = random.choice(TINHTRANGPHIEUDANGKYDN)
    ngaytao = datetime(2022, 1, 1) + (datetime(2024, 6, 30) - datetime(2022, 1, 1)) * random.random()

    phieudangkydoanhnghiep.append([maphieudangkydoanhnghiep, ngaytao, tinhtrang, manhanvien, madn])
    SQL_pdk2 += f'\'{maphieudangkydoanhnghiep}\', to_date(\'{ngaytao.strftime("%Y-%m-%d")}\',\'YYYY-MM-DD\'), N\'{tinhtrang}\', \'{manhanvien}\', \'{madn}\');\n'
    SQL_PHIEUDANGKYDOANHNGHIEP_INSERT += SQL_pdk1 + SQL_pdk2


SQL_PHIEUDANGTUYEN_INSERT = ''
phieudangtuyen = []
for i in range (phieudangtuyen_size):
    
        SQL_pdt1 = '''INSERT INTO ADMIN.PHIEUDANGTUYEN '''
        SQL_pdt2 = 'VALUES ('
    
        maphieudangtuyen = generate_strings("PDT",phieudangtuyen_size)[i]
        vitriungtuyen = random.choice(VITRIUNGTUYEN)
        soluongtuyen = random.randint(1, 10)
        khoangthoigiandangtuyen = str(random.randint(1, 6)) + ' tháng'     
        tieuchi = random.choice(TIEUCHI)
        tongtien = random.randrange(1000000, 10000000 + 1, 500000)
        macongty = random.choice(doanhnghiep)[0]
        manhanvien = random.choice(nhanvien)[0]


        phieudangtuyen.append([maphieudangtuyen, vitriungtuyen, soluongtuyen, khoangthoigiandangtuyen, tieuchi, tongtien, macongty, manhanvien])
        SQL_pdt2 += f'\'{maphieudangtuyen}\', N\'{vitriungtuyen}\', {soluongtuyen}, N\'{khoangthoigiandangtuyen}\', N\'{tieuchi}\', {tongtien}, \'{macongty}\', \'{manhanvien}\');\n'



        SQL_PHIEUDANGTUYEN_INSERT += SQL_pdt1 + SQL_pdt2


SQL_HOADON_INSERT = ''
hoadon = []
for i in range (hoadon_size):
    SQL_hd1 = '''INSERT INTO ADMIN.HOADON '''
    SQL_hd2 = 'VALUES ('

    mahoadon = generate_strings("HD",hoadon_size)[i]    
    hinhthuctt = random.choice(HINHTHUCTT)
    thoigian = datetime(2022, 1, 1) + (datetime(2024, 6, 30) - datetime(2022, 1, 1)) * random.random()

    tongtiencanthanhtoan = phieudangtuyen[i][5]
    tongtiendathanhtoan = 0
    if random.choice([True, False]):
        tongtiendathanhtoan =  random.randrange(500000, tongtiencanthanhtoan, 500000)
        hinhthuctt = HINHTHUCTT[1]
    else:
        tongtiendathanhtoan = tongtiencanthanhtoan

    maphieudangtuyen = phieudangtuyen[i][0]

    hoadon.append([mahoadon, hinhthuctt, thoigian, tongtiendathanhtoan, maphieudangtuyen])
    SQL_hd2 += f'\'{mahoadon}\', N\'{hinhthuctt}\', to_date(\'{thoigian.strftime("%Y-%m-%d")}\',\'YYYY-MM-DD\'), {tongtiendathanhtoan}, \'{maphieudangtuyen}\');\n'
    SQL_HOADON_INSERT += SQL_hd1 + SQL_hd2

SQL_CHIENLUOCUUDAI_INSERT = ''
chienluocuudai = []
for i in range (chienluocuudai_size):

    SQL_clcd1 = '''INSERT INTO ADMIN.CHIENLUOCUUDAI '''
    SQL_clcd2 = 'VALUES ('

    machienluocuudai = generate_strings("CLU",chienluocuudai_size)[i]
    tenchienluocuudai = random.choice(TENCHIENLUOCUUDAI)

    chitietuudai = tenchienluocuudai + " cho doanh nghiệp tiềm năng lớn "

    chienluocuudai.append([machienluocuudai, tenchienluocuudai, chitietuudai])
    SQL_clcd2 += f'\'{machienluocuudai}\', N\'{tenchienluocuudai}\', N\'{chitietuudai}\');\n'

    SQL_CHIENLUOCUUDAI_INSERT += SQL_clcd1 + SQL_clcd2

SQL_BANLANHDAO_INSERT = ''
banlanhdao = []
for i in range (banlanhdao_size):
    SQL_bld1 = '''INSERT INTO ADMIN.BANLANHDAO '''
    SQL_bld2 = 'VALUES ('

    mabananhdao = generate_strings("BLD",banlanhdao_size)[i]
    firstname = random.choice(first_names)
    lastname = random.choice(last_names)
    midname = random.choice(middle_names)

    fullname = lastname + " " + midname + " " + firstname

    banlanhdao.append([mabananhdao, fullname])
    SQL_bld2 += f'\'{mabananhdao}\', N\'{fullname}\');\n'
    SQL_BANLANHDAO_INSERT += SQL_bld1 + SQL_bld2
    
    
SQL_DANHSACHGIAHAN_INSERT = ''
danhsachgiahan = []
for i in range (danhsachgiahan_size):

    SQL_dsg1 = '''INSERT INTO ADMIN.DANHSACHGIAHAN '''
    SQL_dsg2 = 'VALUES ('



    madanhsachgiahan = generate_strings("DS",danhsachgiahan_size)[i]

    ngaylap = datetime(2022, 1, 1) + (datetime(2024, 6, 30) - datetime(2022, 1, 1)) * random.random()
    mabanlanhdao = random.choice(banlanhdao)[0]

    danhsachgiahan.append([madanhsachgiahan, ngaylap, mabanlanhdao])
    SQL_dsg2 += f'\'{madanhsachgiahan}\', to_date(\'{ngaylap.strftime("%Y-%m-%d")}\',\'YYYY-MM-DD\'), \'{mabanlanhdao}\');\n'
    SQL_DANHSACHGIAHAN_INSERT += SQL_dsg1 + SQL_dsg2


SQL_CHITIETGIAHAN_INSERT = ''
chitietgiahan = []
for i in range (chitietgiahan_size):
    
        SQL_ctgh1 = '''INSERT INTO ADMIN.CHITIETGIAHAN '''
        SQL_ctgh2 = 'VALUES ('
    
        tiemnanglon = random.randint(0, 1)       
        machienluocuudai = random.choice(chienluocuudai)[0]
        madanhsachgiahan = danhsachgiahan[i][0]
        macongty = random.choice(doanhnghiep)[0]

    
        chitietgiahan.append([tiemnanglon, machienluocuudai, madanhsachgiahan, macongty])
        SQL_ctgh2 += f'{tiemnanglon}, \'{machienluocuudai}\', \'{madanhsachgiahan}\', \'{macongty}\');\n'
        SQL_CHITIETGIAHAN_INSERT += SQL_ctgh1 + SQL_ctgh2

SQL_HINHTHUC_INSERT = ''
hinhthuc = []
for i in range (hinhthuc_size):

    SQL_ht1 = '''INSERT INTO ADMIN.HINHTHUC '''
    SQL_ht2 = 'VALUES ('

    mahinhthuc = generate_strings("HT",hinhthuc_size)[i]
    tenhinhthuc = TENHINHTHUC[i]
    dongia = random.randrange(100000, 20000000 + 1, 100000)

    hinhthuc.append([mahinhthuc, tenhinhthuc, dongia])
    SQL_ht2 += f'\'{mahinhthuc}\', N\'{tenhinhthuc}\', {dongia});\n'
    SQL_HINHTHUC_INSERT += SQL_ht1 + SQL_ht2    

SQL_PHIEUDANGKYQUANGCAO_INSERT = ''
phieudangkyquangcao = []
for i in range (phieudangkyquangcao_size):

    SQL_pdkqc1 = '''INSERT INTO ADMIN.PHIEUDANGKYQUANGCAO '''
    SQL_pdkqc2 = 'VALUES ('

    maphieudangkyquangcao = generate_strings("QC",phieudangkyquangcao_size)[i]
    thoigiandt = str(random.randint(1, 30)) + " ngày"
    ngaytao = datetime(2022, 1, 1) + (datetime(2024, 6, 30) - datetime(2022, 1, 1)) * random.random()
    maphieudangtuyen = random.choice(phieudangtuyen)[0]
    mahinhthuc = random.choice(hinhthuc)[0]

    phieudangkyquangcao.append([maphieudangkyquangcao, thoigiandt, ngaylap, maphieudangtuyen, mahinhthuc])
    SQL_pdkqc2 += f'\'{maphieudangkyquangcao}\', N\'{thoigiandt}\', to_date(\'{ngaylap.strftime("%Y-%m-%d")}\',\'YYYY-MM-DD\'), \'{maphieudangtuyen}\', \'{mahinhthuc}\');\n'
    SQL_PHIEUDANGKYQUANGCAO_INSERT += SQL_pdkqc1 + SQL_pdkqc2


writefile('INSERT_DATA.sql',SQL_UNGVIEN_INSERT + '\n\n' + SQL_NHANVIEN_INSERT + '\n\n' + SQL_PHIEUUNGTUYEN_INSERT + '\n\n'
            + SQL_HOSOUNGTUYEN_INSERT + '\n\n' + SQL_CHITIETHOSO_INSERT + '\n\n' + SQL_DOANHNGHIEP_INSERT + '\n\n' + SQL_PHIEUDANGKYDOANHNGHIEP_INSERT + '\n\n'
            + SQL_PHIEUDANGTUYEN_INSERT + '\n\n' + SQL_HOADON_INSERT + '\n\n' + SQL_CHIENLUOCUUDAI_INSERT + '\n\n'+ SQL_BANLANHDAO_INSERT + '\n\n'
            + SQL_DANHSACHGIAHAN_INSERT + '\n\n' + SQL_CHITIETGIAHAN_INSERT + '\n\n' + SQL_HINHTHUC_INSERT + '\n\n' + SQL_PHIEUDANGKYQUANGCAO_INSERT + '\n\n'
            
            )

