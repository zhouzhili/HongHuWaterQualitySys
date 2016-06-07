;本程序只针对landsat7影像的多光谱和红外波段进行辐射定标，不对其他传感器影像进行处理
;输入的参数为Landsat标准头文件.MTL.txt文件，以及保存结果的文件夹
PRO ENVIPROVESS_TMCAL_DOIT,inputFile,outputFolder,mb_output=mb_output,thre_output=thre_output
  COMPILE_OPT IDL2
  ; First restore all the base save files.
  ENVI, /RESTORE_BASE_SAVE_FILES
  ;初始化ENVI
  ENVI_BATCH_INIT, LOG_FILE='batch.txt'
  ;测试文件
  ;inputFile='E:\LE71220392012211EDC00\LE71220392012211EDC00_MTL.txt'
  ;outputFolder='E:\LE71220392012211EDC00\tmp'
  ;捕捉错误
  catch,error_status
  errorShow='辐射定标处理过程中发生了错误'
  if Error_status ne 0 then begin
    tmp=dialog_message(errorShow+string(13b)+$
      !error_state.msg,/error,title='错误提示!')
    
    return
  endif
  ; 打开数据
  ENVI_OPEN_DATA_FILE, inputFile, /LANDSAT_METADATA
  ;获取FIDS
  fids = ENVI_GET_FILE_IDS()
  
  ;判断头文件是否可用
  IF (fids[0] EQ -1) THEN BEGIN
    messageDialog=dialog_message('选择的landsat头文件格式错误!',/error)
    ENVI_BATCH_EXIT
    RETURN
  ENDIF
  
  ; 查找多光谱波段
  FOR j = 0, N_ELEMENTS(fids) -1 DO BEGIN
    ENVI_FILE_QUERY, fids[j], NB = nb
    ;获取6个多光谱波段的fid
    IF (nb EQ 6) THEN mb_fid = fids[j]
    ;获取红外
    if (nb EQ 2)then ther_fid=fids[j]
  ENDFOR
  
  ;多光谱辐射定标,定标为辐射率
  if mb_fid eq -1 then begin
    messageDialog=dialog_message('无法获取选择影像的多光谱波段!',/error)
  endif else begin
    mb_output=My_caliration(mb_fid,0,outputFolder)
  endelse
  
  ;红外辐射定标，定标为辐射率
  if ther_fid eq -1 then begin
    messageDialog=dialog_message('无法获取选择影像的红外波段!',/error)
  endif else begin
    thre_output=My_caliration(ther_fid,0,outputFolder)
  endelse
  ;退出envi
  ;ENVI_BATCH_EXIT
END


function My_caliration,fid,cal_type,outputFolder
  ENVI_FILE_QUERY, fid, DIMS =dims, $
    NB = nb, SNAME = sname
  POS = LINDGEN(nb)
  
  ;根据定标的是多光谱还是红外确定输出名称
  if nb eq 2 then begin
    out_name=outputFolder+'\' +file_basename(sname,'_mtl.txt')+ '_Ther_radi.tif'
  endif
  if nb eq 6 then begin
    out_name=outputFolder+'\' +file_basename(sname,'_mtl.txt')+ '_Mul_radi.tif'
  endif
  
  ; 进行辐射定标
  ENVI_DOIT, 'TMCAL_DOIT', $
    FID = fid, POS = pos, DIMS = dims, $
    CAL_TYPE = cal_type, OUT_NAME = out_name, $
    R_FID = r_fid, /USE_METADATA
    
  return,out_name
end

