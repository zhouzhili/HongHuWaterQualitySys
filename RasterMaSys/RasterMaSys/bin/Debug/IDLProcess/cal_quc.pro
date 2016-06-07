;使用的快速大气校正法
PRO CAL_QUC,inputfile,outputfile
  COMPILE_OPT IDL2
  ; First restore all the base save files.
  ENVI, /RESTORE_BASE_SAVE_FILES
  ;初始化ENVI
  ENVI_BATCH_INIT, LOG_FILE='CAL_QUC_batch.txt'
  ;错误捕捉
  catch,error_status
  errorShow='大气校正处理过程中发生了错误'
  if Error_status ne 0 then begin
    tmp=dialog_message(errorShow+string(13b)+$
      !error_state.msg,/error,title='错误提示')
    return
  endif
  ;打开文件
  ENVI_OPEN_FILE, inputfile, r_fid=fid
  IF (fid EQ -1) THEN BEGIN
    tmp=dialog_message(inputfile+string(13b)+'打开失败',/info)
    RETURN
  ENDIF
  ;获取文件信息
  ENVI_FILE_QUERY, fid, dims=dims, nb=nb, sensor_type=sensor_type
  if nb lt 3 then begin
    tmp=dialog_message('大气校正的影像至少需要有三个波段!',/error,title='错误提示')
    return
  endif
  pos  = LINDGEN(nb)
  
  sensor = envi_sensor_type(sensor_type)
  ;调用大气校正参数
  ENVI_DOIT, 'envi_quac_doit', $
    fid=fid, pos=pos, dims=dims, $
    quac_sensor=sensor, $
    out_name=outputfile, r_fid=r_fid
  ;ENVI_BATCH_EXIT
End