#ifndef __COZY_DITTO_CORE__
#define __COZY_DITTO_CORE__

#ifndef COZYDITTO_CORE_IMPORT
#define COZYDITTO_CORE_API _declspec(dllexport)
#else
#define COZYDITTO_CORE_API _declspec(dllimport)
#endif

EXTERN_C COZYDITTO_CORE_API bool RegisterShowWindowHotKey(HWND hWnd, UINT fsModifiers, UINT vk);

EXTERN_C COZYDITTO_CORE_API int GetShowWindowHotKeyId();

EXTERN_C COZYDITTO_CORE_API bool UnregisterShowWindowHotKey(HWND hWnd);

EXTERN_C COZYDITTO_CORE_API bool SetClipboardText(HWND hWnd, LPCTSTR lpText, DWORD dwLength);

EXTERN_C COZYDITTO_CORE_API DWORD GetClipboardText(HWND hWnd, LPTSTR lpResult);

#endif // __COZY_DITTO_CORE__