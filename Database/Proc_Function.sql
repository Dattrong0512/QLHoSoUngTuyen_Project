
--PROCEDURE TẠO TOÀN BỘ USER ỨNG VỚI MẬT KHẨU
CREATE OR REPLACE PROCEDURE USP_CREATE_ALL_USER
AS
    CURSOR CUR IS (SELECT MaNhanVien
                    FROM ADMIN.NhanVien
                    WHERE MaNhanVien NOT IN (SELECT USERNAME FROM ALL_USERS ));
    CURSOR CUR2 IS (SELECT MaCongTy, MatKhau
                    FROM ADMIN.doanhnghiep
                    WHERE MaCongTy NOT IN (SELECT USERNAME FROM ALL_USERS ));
    CURSOR CUR3 IS (SELECT MaUngVien, MatKhau
                    FROM ADMIN.UngVien
                    WHERE MaUngVien NOT IN (SELECT USERNAME FROM ALL_USERS ));
    STRSQL VARCHAR2(1000);
    MK Varchar2(20);
    USR VARCHAR2(20);
BEGIN 
    STRSQL := 'ALTER SESSION SET'||' "_ORACLE_SCRIPT" ='|| 'TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
               
        STRSQL := 'CREATE USER ' || USR || ' IDENTIFIED BY NV456';
        EXECUTE IMMEDIATE(STRSQL);
        
        STRSQL := 'GRANT CONNECT TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;    
    CLOSE CUR;
    
    OPEN CUR2;
    LOOP
        FETCH CUR2 INTO USR, MK;
        EXIT WHEN CUR2%NOTFOUND;
               
        STRSQL := 'CREATE USER ' || USR || ' IDENTIFIED ' || MK;
        EXECUTE IMMEDIATE(STRSQL);
        
        STRSQL := 'GRANT CONNECT TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;    
    CLOSE CUR2;
    
    OPEN CUR3;
    LOOP
        FETCH CUR3 INTO USR,MK;
        EXIT WHEN CUR3%NOTFOUND;
               
        STRSQL := 'CREATE USER ' || USR || ' IDENTIFIED BY ' || MK;
        EXECUTE IMMEDIATE(STRSQL);
        
        STRSQL := 'GRANT CONNECT TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;    
    CLOSE CUR3;
    STRSQL := 'ALTER SESSION SET'||' "_ORACLE_SCRIPT" ='|| 'FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
/
EXECUTE USP_CREATE_ALL_USER;
/
--PROCEDURE GÁN ROLE CHO USER
CREATE OR REPLACE PROCEDURE USP_GRANT_ROLE_USER
AS
    CURSOR CUR IS (SELECT MaNhanVien
                    FROM ADMIN.NhanVien
                    WHERE MaNhanVien IN (SELECT USERNAME FROM ALL_USERS ));
    CURSOR CUR2 IS (SELECT MaCongTy
                    FROM ADMIN.doanhnghiep
                    WHERE MaCongTy IN (SELECT USERNAME FROM ALL_USERS ));
    CURSOR CUR3 IS (SELECT MaUngVien
                    FROM ADMIN.UngVien
                    WHERE MaUngVien IN (SELECT USERNAME FROM ALL_USERS ));
    STRSQL VARCHAR2(1000);
    USR VARCHAR2(20);
BEGIN 
    STRSQL := 'ALTER SESSION SET'||' "_ORACLE_SCRIPT" ='|| 'TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;    
        STRSQL := 'GRANT NHANVIEN TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;    
    CLOSE CUR;
    
    OPEN CUR2;
    LOOP
        FETCH CUR2 INTO USR;
        EXIT WHEN CUR2%NOTFOUND;    
        STRSQL := 'GRANT CONGTY TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;    
    CLOSE CUR2;
    
    OPEN CUR3;
    LOOP
        FETCH CUR3 INTO USR;
        EXIT WHEN CUR3%NOTFOUND;    
        STRSQL := 'GRANT UNGVIEN TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;    
    CLOSE CUR3;
    STRSQL := 'ALTER SESSION SET'||' "_ORACLE_SCRIPT" ='|| 'FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
/
EXECUTE USP_GRANT_ROLE_USER;

--VPD cho bảng NhanVien
CREATE OR REPLACE FUNCTION F_VPD_SELECT_NHANVIEN(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
BEGIN
    user := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
            RETURN 'MaNhanVien='''||user||'''';
    END IF;
END;
/
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'NhanVien',
        policy_name => 'PLC_SELECT_NHANVIEN',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_NHANVIEN',
        statement_types => 'SELECT' );
END;
/
BEGIN
    DBMS_RLS.DROP_POLICY (
        object_schema => 'ADMIN',
        object_name   => 'NhanVien',
        policy_name   => 'PLC_SELECT_NHANVIEN'
    );
END;
/

